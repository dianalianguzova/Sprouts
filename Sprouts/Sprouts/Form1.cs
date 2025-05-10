using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SproutsGame
{
    public partial class Sprouts : Form

    {
        Random Rand;
        Graphics Graph, GraphLine;
        Pen MyPen;
        Brush MyBrush;
        int activeMode =1;

        private List<Vert> verts = new List<Vert>(); //список для хранения координат вершин
        private List<Point> pointsXY = new List<Point>(); //список для хранения координат точек для линий
   
        private List<List<Point>> coordinatesAllPointsXY = new List<List<Point>>(); //для апроксимации 

        private const int radius = 20; //радиус вершины 
        private Player A = null, B = null; //игроки
       
        
    //    bool checkIsNullBoxes = false; //для проверки пустых textbox
        const int step =10;
        const double eps = 1e-9;

        public Sprouts()
        {
            InitializeComponent(); 
            Rand =new Random();
  

        }

        //cоздание точек
        private void createPoints()
        {
            int nVerts = int.Parse(countNBox.Text);

            bool collision = true;
            int x = 0, y = 0;
            for (int i = 0; i < nVerts; i++)
            {
                //проверка на то, чтобы вершины (в виде окружностей) не пересекались
                while (collision)
                {
                    collision = false;
                    x = Rand.Next(200, this.ClientSize.Width - 200);
                    y = Rand.Next(250, this.ClientSize.Height - 250);

                    foreach (Vert point in verts)
                    {
                        if (Math.Abs(point.X - x) < radius * 2 && Math.Abs(point.Y - y) < radius * 2)
                        {
                            collision = true; break;
                        }
                    }
                }
                collision = true;
                verts.Add(new Vert(x, y, 0));
            }
            drawVerts();
        }
        private void ChangeTurns()
        {
            if (A.IsTurn)
            {
                A.IsTurn = false;
                B.IsTurn = true;
            }
            else
            {
                B.IsTurn = false;
                A.IsTurn = true;
            }
        }

        //автоматическая расстановка начальных точек 
        private void drawVerts()
        {
            Graph = CreateGraphics();
            MyPen = new Pen(Color.DimGray, 10);
            MyBrush = new SolidBrush(Color.DarkGray);

            foreach (Vert vert in verts)
            {
                Rectangle rect = new Rectangle(vert.X, vert.Y , radius, radius);
                Graph.DrawEllipse(MyPen, rect);
                Graph.FillEllipse(MyBrush, rect);
            }
        }

   
        private void drawLine(int mode) //отрисовка линии между двумя точками 
        {
            int xNewVert = 0, yNewVert =0;
            GraphLine = CreateGraphics();
            if (pointsXY.Count > 1)
            {
                MyPen = new Pen(Color.DimGray, 5);
                if (mode == 1)
                {
                    GraphLine.DrawCurve(MyPen, pointsXY.ToArray());

                    //координаты для новой точки, которая лежит на середине линии
                    xNewVert = pointsXY[(pointsXY.Count - 1) / 2].X;

                    yNewVert = pointsXY[(pointsXY.Count - 1) / 2].Y;
                    Vert middleVert = new Vert(xNewVert - radius / 2, yNewVert - radius / 2, 2); //2 - т.к. вершина ставится посередине линии
                    verts.Add(middleVert);

                }

                else
                {
                    GraphLine.DrawCurve(MyPen, pointsXY.ToArray());
                    //координаты для новой точки, которая лежит на середине линии
                    xNewVert = pointsXY[1].X;

                    yNewVert = pointsXY[1].Y;
                    Vert middleVert = new Vert(xNewVert - radius / 2, yNewVert - radius / 2, 2); //2 - т.к. вершина ставится посередине линии
                    verts.Add(middleVert);

                }

              drawVerts();

            }
            pointsXY.Clear();

        }

        private void drawAllLines() //отрисовка всех существующих на форме линий после выскакивания ошибок
        {
            foreach(var line in coordinatesAllPointsXY)
            {
                MyPen = new Pen(Color.DimGray, 5);
                GraphLine.DrawCurve(MyPen, line.ToArray());
            }
        }


        Vert vertex1 = null, vertex2 = null; //cсылки на вершины, между которыми возможно будет провести линию

        private bool canDrawLineBetweenTwoVerts(ref int x1, ref int y1, ref int x2, ref int y2)
        {
            vertex1 = null;
            vertex2 = null;
            bool vertex1Check = false, vertex2Check = false;


            //  if (Math.Abs(x2 - x1) < radius * 2) return false; //проверка на то, чтобы между точками было расстояние как минимум двух точек для комфортной игры

            foreach (Vert vert in verts)
            {
                //проверка расстояния между двумя точками - середина окружности и точка начала/конца отрезка (расстояние должно быть меньше радиуса)
                double distanceToFirstPoint = Math.Sqrt(Math.Pow(x1 - (vert.X + radius / 2), 2) + Math.Pow(y1 - (vert.Y + radius / 2), 2));
                double distanceToSecondPoint = Math.Sqrt(Math.Pow(x2 - (vert.X + radius / 2), 2) + Math.Pow(y2 - (vert.Y + radius / 2), 2));


                if (!vertex1Check && distanceToFirstPoint <= radius)
                {
                    vertex1Check = true;
                    vertex1 = vert;
                    x1 = vertex1.X + radius / 2;
                    y1 = vertex1.Y + radius / 2;
                }
                if (!vertex2Check && distanceToSecondPoint <= radius)
                {
                    vertex2Check = true;
                    vertex2 = vert;
                    x2 = vertex2.X + radius / 2;
                    y2 = vertex2.Y + radius / 2;
                }

            }

            if (vertex1Check && vertex2Check)
            {
                bool intersect = intersectLines(x1, y1, x2, y2);
                if (intersect) return false;

                else
                {
                    //добавление к степеням вершин
                    //для петли
                    if (vertex1 == vertex2 && vertex1.Lines <= 1)
                    {
                        vertex1.Lines += 2;
                        return true;
                    }
                    else if (vertex1 != vertex2 && vertex1.Lines <= 2 && vertex2.Lines <= 2)
                    {
                        vertex1.Lines++;
                        vertex2.Lines++;
                        return true;
                    }

                    connectionError.Visible = true;
                    timerErrors.Interval = 1000;
                    timerErrors.Start();
                }
            }   
            return false;
        }


        private void Sprouts_MouseUp(object sender, MouseEventArgs e)
        {
            int x1, y1, x2, y2;

            if (pointsXY.Count >= 4) //чтобы предотвратить исключение 
            {
                x1 = pointsXY[0].X;
                y1 = pointsXY[0].Y;
                x2 = pointsXY[pointsXY.Count - 1].X;
                y2 = pointsXY[pointsXY.Count - 1].Y;
            }
            else return;

            bool canDrawLine = canDrawLineBetweenTwoVerts(ref x1, ref y1, ref x2, ref y2);
            
            if (canDrawLine)
            { 
                //изменение начальной и конечной точки: при проверке соединений линий, если их можно соединить, то начало и конец будут лежать в центре окружностей
                Point p = pointsXY[0];
                p.X = x1;
                p.Y = y1;
                pointsXY[0] = p;

                //p.X = x1 + radius/2;
                //p.Y = y1 + radius/2;
                //pointsXY[1] = p;

                //p.X = x2 - radius/2;
                //p.Y = y2 - radius/2;
                //pointsXY[pointsXY.Count - 2] = p;

                p.X = x2;
                p.Y = y2;
                pointsXY[pointsXY.Count - 1] = p;

                coordinatesAllPointsXY.Add(new List<Point>(pointsXY));
                drawLine(1);
                ChangeTurns();
            }
            else
            {
                pointsXY.Clear();
            }

            if (A.IsTurn == true)
            {
                moveLabel.Text = "Ход игрока: " + A.Name;
            }
            else
            {
                moveLabel.Text = "Ход игрока: " + B.Name;
            }
        }


        private void timerErrors_Tick(object sender, EventArgs e)
        {
            intersectError.Visible = false; // Скрываем метку
            connectionError.Visible = false;
            drawAllLines(); //отрисовка всех линий и вершин на форме, так как "ошибка" накладывается сверху всех элементов 
            drawVerts();
            timerErrors.Stop(); // Останавливаем таймер
        }



        //   проверка пересечения новой линии с какой-нибудь на форме
        private bool intersectLines(int x1, int y1, int x2, int y2)
        {

            int i = 0;
            // Проверка на самопересечение
            for (; i < pointsXY.Count; i++)
            {
                for (int j = i + 2; j < pointsXY.Count - 1; j++)
                {
                    // Необходимо проверять пересечение сегментов [i, i+1] и [k, k+1]
                    if (checkIntersect(pointsXY[i], pointsXY[i + 1], pointsXY[j], pointsXY[j + 1]))
                    {
                        intersectError.Visible = true;
                        timerErrors.Interval = 1000;
                        timerErrors.Start();
                        return true;
                    }
                }
            }



            for (i = 10 ; i < pointsXY.Count-10 ; i+=10)
            {
                Point newLineA = pointsXY[i];
                Point newLineB = pointsXY[i + 10];

                    // if (!(Math.Sqrt(Math.Pow(newLineA.X - x1, 2) + Math.Pow(newLineB.Y - y1, 2)) < radius) || !(Math.Sqrt(Math.Pow(newLineA.X - x2, 2) + Math.Pow(newLineB.Y - y2, 2)) < radius))
                    // {
                    //проверка всех сегментов всех существующих линий на пересечение с сегментами той, которую хотим нарисовать
                    foreach (var segment in coordinatesAllPointsXY)
                    {
                        for (int j = 1; j < segment.Count - 10; j += 10)
                        {

                            Point prevLineA = segment[j];
                            Point prevLineB = segment[j + 10];


                        //MyPen = new Pen(Color.Red, 7);
                        //Graph.DrawLine(MyPen, newLineA, newLineB);


                        //MyPen = new Pen(Color.Blue, 7);

                        //Graph.DrawLine(MyPen, prevLineA, prevLineB);

                        //MyPen = new Pen(Color.Green, 7);
                        //Graph.DrawLine(MyPen, newLineA, newLineB);

                        //Graph.DrawLine(MyPen, prevLineA, prevLineB);


                        //if (!(Math.Sqrt(Math.Pow(prevLineA.X - x1, 2) + Math.Pow(prevLineB.Y - y1, 2)) < radius) || !(Math.Sqrt(Math.Pow(prevLineA.X - x2, 2) + Math.Pow(prevLineB.Y - y2, 2)) < radius))
                        //  {

                        if (checkIntersect(newLineA, newLineB, prevLineA, prevLineB))
                            {


                            //MyBrush = new SolidBrush(Color.Red);
                            //Rectangle rect = new Rectangle(newLineA.X, newLineA.Y, radius / 2, radius / 2);
                            //Graph.DrawEllipse(MyPen, rect);
                            //Graph.FillEllipse(MyBrush, rect);

                            intersectError.Visible = true;
                                timerErrors.Interval = 1000;
                                timerErrors.Start();
                                return true;
                            }
                    }
                }
                   // }
                //}
            }
            return false;
        }

      
        private void Sprouts_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) pointsXY.Add(new Point(e.X, e.Y));        
        }


        private bool checkIntersect(Point r1, Point r2, Point p1, Point p2)
        {
            //координаты направления вектора первого отрезка
            double v = r2.X - r1.X;
            double w = r2.Y - r1.Y;
            //координаты направления вектора второго отрезка
            double v2 = p2.X - p1.X;
            double w2 = p2.Y - p1.Y;

            // Знаменатель в вычислении параметров t и t2
            double denominator = w * v2 - v * w2;

            // Проверка параллельности отрезков
            if (denominator == 0) return false;

            // Вычисление параметров на основе формулы пересечения
            double t2 = (-w * (p1.X - r1.X) + v * (p1.Y - r1.Y)) / denominator;
            double t = (v2 * (p1.Y - r1.Y) - w2 * (p1.X - r1.X)) / denominator;

            // Проверка условий принадлежности точки пересечения обоим отрезкам
            if (t < 0 || t > 1 || t2 < 0 || t2 > 1)
            {
               return false;
            }
            return true;
        }


        bool isCompLineIntersects(int x1, int y1, int x2, int y2)
        {
            Point newLineA = pointsXY[0];
            Point newLineB = pointsXY[1];

            foreach (var segment in coordinatesAllPointsXY)
            {
                if (newLineA == segment[0] || newLineB == segment[0] || newLineA == segment[1] || newLineB == segment[1]) return true;
                for (int j = 10; j < segment.Count - 10; j+=10)
                {

                    Point prevLineA = segment[j];
                    Point prevLineB = segment[j + 10];


                    if (newLineA == prevLineA || newLineA == prevLineB || newLineB == prevLineA || newLineB == prevLineB)
                    {
                        return false;
                    }

                    //MyPen = new Pen(Color.Red, 7);
                    //Graph.DrawLine(MyPen, newLineA, newLineB);


                    //MyPen = new Pen(Color.Blue, 7);
                    //Graph.DrawLine(MyPen, prevLineA, prevLineB);
                    //MyPen = new Pen(Color.Green, 7);
                    //Graph.DrawLine(MyPen, newLineA, newLineB);
                    //Graph.DrawLine(MyPen, prevLineA, prevLineB);

                    if (!(Math.Sqrt(Math.Pow(prevLineA.X - x1, 2) + Math.Pow(prevLineB.Y - y1, 2)) < radius) || !(Math.Sqrt(Math.Pow(prevLineA.X - x2, 2) + Math.Pow(prevLineB.Y - y2, 2)) < radius))
                    {

                        if (checkIntersect(newLineA, newLineB, prevLineA, prevLineB))
                        {
                            return true;
                        }
                    }
                }        
            }
            return false;
        }

        private void ComputerMove()
        {
            for(int i=0;i<verts.Count-1;i++)
            {
                int x1 = verts[i].X;
                int y1 = verts[i].Y;
                int x2 = verts[i+1].X; //координаты точек, которые будет пытаться соединять компьютер
                int y2 = verts[i+1].Y;
                bool canComputerDrawLine = false;
            
                pointsXY.Add(new Point(x1 +radius/2 , y1 +radius/2 ));
                pointsXY.Add(new Point(x2 +radius/2, y2 +radius/2));
         
                bool checkIntersectCompLine = isCompLineIntersects(x1, y1, x2, y2);

                if (!checkIntersectCompLine) canComputerDrawLine = canDrawLineBetweenTwoVerts(ref x1, ref y1,ref  x2,ref y2);

                if (canComputerDrawLine && !checkIntersectCompLine && B.IsTurn)
                {
                    pointsXY.Clear();
                    pointsXY.Add(new Point(x1 + radius / 2, y1 + radius / 2)); // начало линии
                  //  int d = (int)Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
                    //pointsXY.Add(new Point((x1+x2)/2 + d/4, (y1+y2)/2+d/4)); 
                    pointsXY.Add(new Point(x2 + radius / 2, y2 + radius / 2)); // начало линии

                    coordinatesAllPointsXY.Add(new List<Point>(pointsXY));

                    drawLine(2);
                    drawVerts();
                    ChangeTurns();
                    return;
                }
                else pointsXY.Clear();

            }
        }
        

        private void createPlayersByName(int mode)
        {
            string player1Name = player1Box.Text;
            string player2Name = player2Box.Text;

            if (mode == 1)
            {
                A = new Player(player1Name);
                B = new Player(player2Name);
            }
            else
            {
                A = new Player(player1Name);        
                B = new Player("Компьютер");
            }

            string moveP1 = "Ход игрока: " + A.Name;
         //   string moveP2 = "Ход игрока " + B.Name;

            moveLabel.Text = moveP1;
        }


        private void startMode1Button_Click(object sender, EventArgs e)
        {

            this.KeyPreview = true; 
            activeMode = 1;
           // A.IsTurn = true;

        //    checkIsNullBoxes = checkIsPlayersBoxesNull();
          //  if (checkIsNullBoxes) return;

            player1Label.Visible = false;
            player2Label.Visible = false;
            countNLabel.Visible = false;
            startMode1Button.Visible = false;
            player1Box.Visible = false;
            player2Box.Visible = false;
            countNBox.Visible = false;
            backToChoiceModeButton.Visible = false;


            moveLabel.Visible = true;
            buttonFinishGame.Visible = true;


            createPlayersByName(1);

            moveLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - moveLabel.Width / 2,  moveLabel.Height /2 );
            buttonFinishGame.Location = new System.Drawing.Point(ClientSize.Width/2 - buttonFinishGame.Width/2, ClientSize.Height -  buttonFinishGame.Height * 3/2);

            createPoints();
  
            this.MouseUp += new MouseEventHandler(Sprouts_MouseUp);

        }

        private void startMode2Button_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            activeMode = 2;
            player1Label.Visible = false;
            player2Label.Visible = false;
            countNLabel.Visible = false;
            startMode2Button.Visible = false;
            player1Box.Visible = false;
            player2Box.Visible = false;
            countNBox.Visible = false;
            backToChoiceModeButton.Visible = false;

            moveLabel.Visible = true;
            buttonFinishGame.Visible = true;

            createPlayersByName(2);

            moveLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - moveLabel.Width / 2, moveLabel.Height);
            buttonFinishGame.Location = new System.Drawing.Point(ClientSize.Width / 2 - buttonFinishGame.Width / 2, ClientSize.Height - buttonFinishGame.Height * 3 / 2);

            createPoints();

            this.MouseUp += new MouseEventHandler(Sprouts_MouseUp);

        }


        private void player1Box_TextChanged(object sender, EventArgs e)
        {
            player1Box.BackColor = Color.WhiteSmoke;
        }
        private void player2Box_TextChanged(object sender, EventArgs e)
        {
            player2Box.BackColor = Color.WhiteSmoke;
        }
        private void Sprouts_Load(object sender, EventArgs e)
        {
            countNBox.Minimum = 1;
            countNBox.Maximum = 10;

            //основное меню
            gameNameLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - gameNameLabel.Width / 2, ClientSize.Height / 2 - gameNameLabel.Height / 2 - gameNameLabel.Height * 2);
            startGameButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - startGameButton.Width / 2, ClientSize.Height / 2 - startGameButton.Height / 2 - startGameButton.Height);
            roolsButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - roolsButton.Width / 2, ClientSize.Height / 2);
            controlButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - controlButton.Width / 2, ClientSize.Height/2 + controlButton.Height / 2 + controlButton.Height);
            exitButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - exitButton.Width / 2, ClientSize.Height / 2  + exitButton.Height * 3);


            //правила игры 
            if (ClientSize.Height < 600 || ClientSize.Width < 750) roolLabel.Font = new Font(roolLabel.Font.FontFamily, 10, FontStyle.Bold);
            else roolLabel.Font = new Font(roolLabel.Font.FontFamily, 14, FontStyle.Bold);
            roolsMainLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - roolsMainLabel.Width / 2, ClientSize.Height / 2 - roolsMainLabel.Height / 2 - roolsMainLabel.Height * 3);
            backToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - backToMenuButton.Width / 2, ClientSize.Height - backToMenuButton.Height * 2);
            roolLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - roolLabel.Width / 2, roolsMainLabel.Location.Y + 100);

            //управление
            controlLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - controlLabel.Width / 2, ClientSize.Height / 2 - controlLabel.Height*2);
            backToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - backToMenuButton.Width / 2, ClientSize.Height - backToMenuButton.Height * 2);
            controlTextLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - controlTextLabel.Width / 2, controlLabel.Location.Y + 150);

            //начать игру
            mode1Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - mode1Button.Width / 2, ClientSize.Height / 2 - mode1Button.Height / 2 - mode1Button.Height);
            mode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - mode2Button.Width / 2, ClientSize.Height / 2);
            modeLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - modeLabel.Width / 2, ClientSize.Height / 2 - modeLabel.Height / 2 - modeLabel.Height * 2);

            //режим 1
            countNLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - countNLabel.Width, ClientSize.Height / 2 - countNLabel.Height * 3);
            player1Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - countNLabel.Width, ClientSize.Height / 2 - countNLabel.Height * 3 + player1Label.Height * 3);
            player2Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - countNLabel.Width, ClientSize.Height / 2 - countNLabel.Height * 3 + player2Label.Height * 5);
            countNBox.Location = new System.Drawing.Point(ClientSize.Width / 2 + countNBox.Width / 2, ClientSize.Height / 2 - countNLabel.Height * 5 / 2);
            player1Box.Location = new System.Drawing.Point(ClientSize.Width / 2 + player1Box.Width / 2, ClientSize.Height / 2 - countNLabel.Height * 3 + player1Label.Height * 3);
            player2Box.Location = new System.Drawing.Point(ClientSize.Width / 2 + player2Box.Width / 2, ClientSize.Height / 2 - countNLabel.Height * 3 + player2Label.Height * 5);
            startMode1Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - startMode1Button.Width / 2, ClientSize.Height / 2 + player2Label.Height * 2);
            backToChoiceModeButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - startMode1Button.Width / 2, ClientSize.Height / 2 + startMode1Button.Height * 5 / 2);

            //режим 2
            startMode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - startMode1Button.Width / 2, ClientSize.Height / 2 + player2Label.Height * 2);

            //сообщения об ошибках
            intersectError.Location = new System.Drawing.Point(ClientSize.Width / 2 - intersectError.Width / 2, ClientSize.Height / 2 - intersectError.Height / 2);
            connectionError.Location = new System.Drawing.Point(ClientSize.Width / 2 - connectionError.Width / 2, ClientSize.Height / 2 - connectionError.Height / 2);

            //режим 1 начать игру
            // moveP1Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - moveP1Label.Width / 2, moveP1Label.Height);
            //  moveP2Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - moveP2Label.Width / 2, moveP2Label.Height * 2);
        }

        private void Sprouts_Resize(object sender, EventArgs e)

        {

            //основное меню
            gameNameLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - gameNameLabel.Width / 2, ClientSize.Height / 2 - gameNameLabel.Height / 2 - gameNameLabel.Height * 2);
            startGameButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - startGameButton.Width / 2, ClientSize.Height / 2 - startGameButton.Height / 2 - startGameButton.Height);
            roolsButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - roolsButton.Width / 2, ClientSize.Height / 2);
            controlButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - controlButton.Width / 2, ClientSize.Height / 2 + controlButton.Height / 2 + controlButton.Height);
            exitButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - exitButton.Width / 2, ClientSize.Height / 2 + exitButton.Height * 3);


            //правила
            roolsMainLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - roolsMainLabel.Width / 2, ClientSize.Height / 2 - roolsMainLabel.Height / 2 - roolsMainLabel.Height * 3);
            backToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - backToMenuButton.Width / 2, ClientSize.Height - backToMenuButton.Height * 2);
            if (ClientSize.Height < 600 || ClientSize.Width < 750) roolLabel.Font = new Font(roolLabel.Font.FontFamily, 10, FontStyle.Bold);
            else roolLabel.Font = new Font(roolLabel.Font.FontFamily, 14, FontStyle.Bold);
            roolLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - roolLabel.Width / 2, roolsMainLabel.Location.Y + 100);

            //управление
            controlLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - controlLabel.Width / 2, ClientSize.Height / 2 - controlLabel.Height * 2);
            backToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - backToMenuButton.Width / 2, ClientSize.Height - backToMenuButton.Height * 2);
            controlTextLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - controlTextLabel.Width / 2, controlLabel.Location.Y + 150);

            //начать игру
            mode1Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - mode1Button.Width / 2, ClientSize.Height / 2 - mode1Button.Height / 2 - mode1Button.Height);
            mode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - mode2Button.Width / 2, ClientSize.Height / 2);
            modeLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - modeLabel.Width / 2, ClientSize.Height / 2 - modeLabel.Height / 2 - modeLabel.Height * 2);

            //режим 1
            countNLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - countNLabel.Width, ClientSize.Height / 2 - countNLabel.Height * 3);
            player1Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - countNLabel.Width, ClientSize.Height / 2 - countNLabel.Height * 3 + player1Label.Height * 3);
            player2Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - countNLabel.Width, ClientSize.Height / 2 - countNLabel.Height * 3 + player2Label.Height * 5);
            countNBox.Location = new System.Drawing.Point(ClientSize.Width / 2 + countNBox.Width / 2, ClientSize.Height / 2 - countNLabel.Height * 5 / 2);
            player1Box.Location = new System.Drawing.Point(ClientSize.Width / 2 + player1Box.Width / 2, ClientSize.Height / 2 - countNLabel.Height * 3 + player1Label.Height * 3);
            player2Box.Location = new System.Drawing.Point(ClientSize.Width / 2 + player2Box.Width / 2, ClientSize.Height / 2 - countNLabel.Height * 3 + player2Label.Height * 5);
            startMode1Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - startMode1Button.Width / 2, ClientSize.Height / 2 + player2Label.Height * 2);
            backToChoiceModeButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - startMode1Button.Width / 2, ClientSize.Height / 2 + startMode1Button.Height * 5 / 2);

            //режим 1-2 процесс игры
            moveLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - moveLabel.Width / 2,  moveLabel.Height /2 );
            buttonFinishGame.Location = new System.Drawing.Point(ClientSize.Width / 2 - buttonFinishGame.Width / 2, ClientSize.Height - buttonFinishGame.Height * 3 / 2);
            labelWin.Location = new System.Drawing.Point(ClientSize.Width / 2 - labelWin.Width / 2, ClientSize.Height / 2 - labelWin.Height);

            //просмотр правил игры во время игры
            backToGameButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - backToGameButton.Width / 2, ClientSize.Height - buttonFinishGame.Height *4);

            //режим 2
            startMode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - startMode1Button.Width / 2, ClientSize.Height / 2 + player2Label.Height * 2);

            //сообщения об ошибках
            intersectError.Location = new System.Drawing.Point(ClientSize.Width / 2 - intersectError.Width / 2, ClientSize.Height / 2 - intersectError.Height / 2);
            connectionError.Location = new System.Drawing.Point(ClientSize.Width / 2 - connectionError.Width / 2, ClientSize.Height / 2 - connectionError.Height / 2);

        }
        private void roolsButton_Click(object sender, EventArgs e)
        {
            gameNameLabel.Visible = false;
            startGameButton.Visible = false;
            roolsButton.Visible = false;
            controlButton.Visible = false;
            exitButton.Visible = false;

            roolsMainLabel.Visible = true;
            backToMenuButton.Visible = true;
            roolLabel.Visible = true;
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            roolsMainLabel.Visible = false;
            roolLabel.Visible = false;
            backToMenuButton.Visible = false;
            mode1Button.Visible = false;
            mode2Button.Visible = false;
            modeLabel.Visible = false;
            labelWin.Visible = false;
            controlTextLabel.Visible = false;
            controlLabel.Visible = false;
            backToGameButton.Visible = false;

            labelWin.Text = "Победа игрока "; //сброс полей 
            player1Box.Text = "A";
            player2Box.Text = "B";
            countNBox.Value = 1;
            verts.Clear();
            coordinatesAllPointsXY.Clear();
            
            gameNameLabel.Visible = true;
            startGameButton.Visible = true;
            roolsButton.Visible = true;
            controlButton.Visible = true;
            exitButton.Visible = true;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            
            gameNameLabel.Visible = false;
            startGameButton.Visible = false;
            roolsButton.Visible = false;
            controlButton.Visible = false;
            exitButton.Visible = false;

            mode1Button.Visible = true;
            mode2Button.Visible = true;
            backToMenuButton.Visible = true;
            modeLabel.Visible = true;

        }

        private void mode1Button_Click(object sender, EventArgs e)
        {
            modeLabel.Visible = false;
            mode1Button.Visible = false;
            mode2Button.Visible = false;
            backToMenuButton.Visible = false;

            player1Label.Visible = true;
            player2Label.Visible = true;
            countNLabel.Visible = true;
            startMode1Button.Visible = true;
            player1Box.Visible = true;
            player2Box.Visible = true;
            countNBox.Visible = true;
            backToChoiceModeButton.Visible = true;

        }
        private void backToChoiceModeButton_Click(object sender, EventArgs e)
        {
            player1Label.Visible = false;
            player2Label.Visible = false;
            countNLabel.Visible = false;
            startMode1Button.Visible = false;
            player1Box.Visible = false;
            player2Box.Visible = false;
            countNBox.Visible = false;
            backToChoiceModeButton.Visible = false;
            startGameButton.Visible = false;
            startMode2Button.Visible = false;

            labelWin.Text = "Победа игрока "; //сброс полей 
            player1Box.Text = "A";
            player2Box.Text = "B";
            countNBox.Value = 1;
            verts.Clear();
            coordinatesAllPointsXY.Clear();

            modeLabel.Visible = true;
            mode1Button.Visible = true;
            mode2Button.Visible = true;
            backToMenuButton.Visible = true;
        }

        private void mode2Button_Click(object sender, EventArgs e)
        {
            modeLabel.Visible = false;
            mode1Button.Visible = false;
            mode2Button.Visible = false;
            backToMenuButton.Visible = false;

            countNBox.Visible = true;
            countNLabel.Visible = true;
            player1Box.Visible = true;
            player1Label.Text = "Игрок 1:";
            player1Label.Visible = true;
            startMode2Button.Visible = true ;
            backToChoiceModeButton.Visible = true;

        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            gameNameLabel.Visible = false;
            startGameButton.Visible = false;
            roolsButton.Visible = false;
            controlButton.Visible = false;
            exitButton.Visible = false;

            controlLabel.Visible = true;
            controlTextLabel.Visible = true;
            backToMenuButton.Visible = true;
        }


        private void Sprouts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                moveLabel.Visible = false;
                buttonFinishGame.Visible = false;
                Graph.Clear(Color.LightGray);

                roolsMainLabel.Visible = true;
                roolLabel.Visible = true;
                
                backToGameButton.Visible = true;
                backToMenuButton.Visible = true;
            }
        }

        //возвращение к игре после просмотра правил
        private void backToGameButton_Click(object sender, EventArgs e)
        {
            backToGameButton.Visible = false;
            backToMenuButton.Visible = false;
            roolLabel.Visible = false;
            roolsMainLabel.Visible = false;

            moveLabel.Visible = true;
            buttonFinishGame.Visible = true;
            
            drawAllLines();
            drawVerts();
        }

        private void buttonFinishGame_Click(object sender, EventArgs e)
        {
            buttonFinishGame.Visible = false;
            moveLabel.Visible = false;

            Graph.Clear(Color.LightGray);

            backToMenuButton.Visible = true;
            labelWin.Visible = true;
        
            //если игрок не может сделать ход, выигрывает соперник
            if (A.IsTurn == true) labelWin.Text = labelWin.Text + B.Name + "!";
            else labelWin.Text = labelWin.Text + A.Name + "!";

            labelWin.Location = new System.Drawing.Point(ClientSize.Width / 2 - labelWin.Width / 2, ClientSize.Height / 2 - labelWin.Height);

        }


        //проверка если поля имени игроков пустые
        private bool checkIsPlayersBoxesNull()
        {
            bool checkIsNull = false;

            if (string.IsNullOrWhiteSpace(player1Box.Text) && string.IsNullOrWhiteSpace(player2Box.Text))
            {
                player1Box.BackColor = Color.MistyRose;
                player2Box.BackColor = Color.MistyRose;
                checkIsNull = true;
            }
            else if (string.IsNullOrWhiteSpace(player1Box.Text) && !string.IsNullOrWhiteSpace(player2Box.Text))
            {
                player1Box.BackColor = Color.MistyRose;
                player2Box.BackColor = Color.WhiteSmoke;
                checkIsNull = true;
            }
            else if (!string.IsNullOrWhiteSpace(player1Box.Text) && string.IsNullOrWhiteSpace(player2Box.Text))
            {
                player2Box.BackColor = Color.MistyRose;
                player1Box.BackColor = Color.WhiteSmoke;
                checkIsNull = true;
            }

            return checkIsNull;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//
//  MyPen = new Pen(Color.Red, 7);
//// Рисуем первый сегмент
//Graph.DrawLine(MyPen, segment1.Start.X, segment1.Start.Y, segment1.End.X, segment1.End.Y);

//MyPen = new Pen(Color.DarkBlue, 7);
//// Рисуем второй сегмен
//Graph.DrawLine(MyPen, segment2.Start.X, segment2.Start.Y, segment2.End.X, segment2.End.Y);