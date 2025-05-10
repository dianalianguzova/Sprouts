using Sprouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using SproutsGame;



namespace SproutsGame
{
    public enum ErrorType
    {
        Intersection, Connection, None, Other
    }
    public enum ScreenName
    {
        BackMenu, Retry, Rules, EndGame, Info
    }
    public enum ActivePlayer
    {
        Player, Computer
    }
    public partial class Sprouts : Form
    {
        private Graphics Graph;
        private Pen MyPen;
        private Brush MyBrush;
       
        private List<Vert> verts = new List<Vert>(); //список для хранения координат вершин
        private List<Point> pointsXY = new List<Point>(); //список для хранения координат точек для линий  
        private List<List<Point>> coordinatesAllPointsXY = new List<List<Point>>();

        private Player A = null, B = null; //игроки
        private int movesCounter = 0; //счетчик ходов
        private int nVerts = 1; //количество вершин 
        private int activeMode = 1; 
        private Button prevButton = null; //сохранение предыдущей кнопки для выбора начального кол-ва точек 
        public Sprouts()
        {
            InitializeComponent();
            Graph = CreateGraphics();
        }
        private void ShowError(ErrorType type)
        {
            switch (type)
            {
                case ErrorType.Intersection:
                    IntersectError.Visible = true;
                    break;
                case ErrorType.Connection:
                    connectionError.Visible = true;
                    break;
                default: break;
            }
            TimerErrors.Interval = 1000;
            TimerErrors.Start();           
        }
        private void TimerErrors_Tick(object sender, EventArgs e)
        {
            IntersectError.Visible = false;
            connectionError.Visible = false;
            Redraw();
            TimerErrors.Stop();
        }
        private void DrawVerts() //автоматическая отрисовка точек
        {
            MyPen = new Pen(Color.SaddleBrown, 7);
            foreach (Vert vert in verts)
            {
                if (vert.Lines != 3) MyBrush = new SolidBrush(Color.Sienna);
                else MyBrush = new SolidBrush(Color.Red); //цвет в зависимости от степени вершины

                Rectangle rect = new Rectangle(vert.X, vert.Y, CommonVariable.radius * 2, CommonVariable.radius * 2);
                Graph.DrawEllipse(MyPen, rect);
                Graph.FillEllipse(MyBrush, rect);
            }     
        }
        private void DrawLine(ActivePlayer player) //отрисовка линии между двумя точками и точки на ее середине
        {
            if (A.IsTurn) MyPen = new Pen(Color.SeaGreen, 5);
            else MyPen = new Pen(Color.RoyalBlue, 5);
            Graph.DrawCurve(MyPen, pointsXY.ToArray());

            Vert middleV = SproutsAlgorithms.CreateMiddlePoint(pointsXY);
            verts.Add(middleV);
            DrawVerts();
            pointsXY.Clear();
        }
        private void Redraw() //перерисовка линий и точек 
        {
            Graph.Clear(Color.MintCream);
            int countline = 0; //для того, чтобы перерисовка была с соответствующими цветами
            foreach (var line in coordinatesAllPointsXY)
            {
                if (countline % 2 == 0) MyPen = new Pen(Color.SeaGreen, 5);
                else MyPen = new Pen(Color.RoyalBlue, 5);
                Graph.DrawCurve(MyPen, line.ToArray());
                countline++;
            }
            DrawVerts();
        }
        private void TakeMove(ActivePlayer player)
        {
            coordinatesAllPointsXY.Add(new List<Point>(pointsXY));
            if (player == ActivePlayer.Computer)
                System.Threading.Thread.Sleep(2000);//задержка хода
            DrawLine(player);
            ChangeTurns();
        }
        private void Sprouts_MouseUp(object sender, MouseEventArgs e)
        {
            if (pointsXY.Count < 4) return; //если не нашлось 4 точки - линия не отрисована верно

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref pointsXY, coordinatesAllPointsXY);
            if (error == ErrorType.None)
            {
                TakeMove(ActivePlayer.Player);
                if (activeMode == 2)
                {
                    pointsXY = Computer.ComputerMove(verts, coordinatesAllPointsXY);
                    if (pointsXY.Count != 0)
                        TakeMove(ActivePlayer.Computer);
                    else
                    {
                        pointsXY.Clear();
                        System.Threading.Thread.Sleep(3000);
                        ButtonFinishGame.PerformClick();
                        return;
                    }
                }
            }
            else
            {
                ShowError(error);
                pointsXY.Clear();  //если ход неверный, список координат текущей линии очищается    
            }
        }
        private void Sprouts_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) pointsXY.Add(new Point(e.X, e.Y));
        }
        private void Reset(ScreenName name) //сброс полей в зависимости от экрана
        {
            verts.Clear();
            coordinatesAllPointsXY.Clear();
            LabelCountMove.Text = "Количество ходов: 0";
            movesCounter = 0;
            switch (name)
            {
                case ScreenName.BackMenu:
                    LabelWin.Text = "Победа игрока ";
                    Player1Box.Text = "A"; Player2Box.Text = "B";
                    prevButton.BackColor = Color.MintCream; //кнопка выбора кол-ва точек
                    prevButton.ForeColor = Color.FromArgb(0, 64, 0);
                    prevButton = n1; 
                    n1.BackColor = Color.SeaShell;
                    n1.ForeColor = Color.Maroon;
                    nVerts = 1;
                    Player2Box.ReadOnly = false;
                    break;
                case ScreenName.Retry:
                    if (B.IsTurn)
                    {
                        B.IsTurn = false; A.IsTurn = true;
                        MoveLabel.Text = "Ход игрока: " + A.Name;
                        MoveLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - MoveLabel.Width / 2, MoveLabel.Height * 3);
                    }
                    verts = SproutsAlgorithms.CreatePoints(nVerts, this.ClientSize.Width, this.ClientSize.Height);
                    DrawVerts();
                    break;
                default: break;
            }
        }
        private void RemoveGameField(ScreenName name) //закрытие экрана игрового поля
        {
            this.KeyPreview = false;
            MoveLabel.Visible = false;
            ButtonFinishGame.Visible = false;
            infButton.Visible = false;
            retryButton.Visible = false;
            WhileGamePicBox.Visible = false;
            LabelCountMove.Visible = false;
            BackFramePicBox.Visible = true;
            switch (name)
            {
                case ScreenName.EndGame:
                    LabelCountMove.Visible = true;
                    LabelWin.Visible = true;
                    BackFramePicBox.Visible = true;
                    BackToMenuButton.Visible = true;
                    break;
                case ScreenName.Info:
                    Graph.Clear(Color.MintCream);
                    break;
                default: break;
            }
        }
        private void ChangeTurns()
        {
            bool temp = A.IsTurn;
            A.IsTurn = B.IsTurn;
            B.IsTurn = temp;
            if (A.IsTurn) MoveLabel.Text = "Ход игрока: " + A.Name;
            else
            {
                if (activeMode == 1) MoveLabel.Text = "Ход игрока: " + B.Name;
                else MoveLabel.Text = "Ход компьютера";
            }
            movesCounter++;
            LabelCountMove.Text = "Количество ходов: " + movesCounter.ToString();
            LabelCountMove.Refresh();
            MoveLabel.Refresh(); //обновление лейблов 
            MoveLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - MoveLabel.Width / 2, MoveLabel.Height * 3);
        }
        private void InfButton_Click(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            RemoveGameField(ScreenName.Info);
            ShowRules(ScreenName.Info);
            BackToGameButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - BackToGameButton.Width / 2, ClientSize.Height / 2 + BackToGameButton.Height * 6);
        }
        private void CreatePlayersByName()
        {
            string player1Name = Player1Box.Text;
            string player2Name = Player2Box.Text;

            A = new Player(player1Name,true);
            if (activeMode == 1) B = new Player(player2Name, false);
            else B = new Player("Компьютер", false);

            string moveP1 = "Ход игрока: " + A.Name;
            MoveLabel.Text = moveP1;
        }
        private void ButtonFinishGame_Click(object sender, EventArgs e)
        {
            Graph.Clear(Color.LightGray);
            RemoveGameField(ScreenName.EndGame);         
            if (A.IsTurn) LabelWin.Text = LabelWin.Text + B.Name + "!";  //если игрок не может сделать ход, выигрывает соперник       
            else
            {
                if (B.Name == "Компьютер")LabelWin.Text = "Компьютеру не удалось найти ход. " + LabelWin.Text + A.Name + "!";    
                else LabelWin.Text = LabelWin.Text + A.Name + "!";
            }
            LabelWin.Location = new System.Drawing.Point(ClientSize.Width / 2 - LabelWin.Width / 2, ClientSize.Height / 2 - LabelWin.Height);
            LabelCountMove.Location = new System.Drawing.Point(ClientSize.Width / 2 - LabelCountMove.Width / 2, ClientSize.Height / 2 + LabelCountMove.Height);
            BackToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - BackToMenuButton.Width / 2, LabelCountMove.Location.Y + BackToMenuButton.Height*2);          
        }

        private void ShowGameField()
        {
            this.KeyPreview = true;
            MoveLabel.Visible = true;
            LabelCountMove.Visible = true;
            ButtonFinishGame.Visible = true;
            retryButton.Visible = true;
            infButton.Visible = true;
            WhileGamePicBox.Visible = true;
        }
        private void RemoveMainMenu()
        {
            GameNameLabel.Visible = false;
            StartGameButton.Visible = false;
            RulesButton.Visible = false;
            ControlButton.Visible = false;
            ExitButton.Visible = false;
        }
        private void BackToMainMenu()
        {
            LabelCountMove.Visible = false;
            GameNameLabel.Visible = true;
            StartGameButton.Visible = true;
            RulesButton.Visible = true;
            ControlButton.Visible = true;
            ExitButton.Visible = true;
            BackFramePicBox.Visible = true;
        }
        private void ShowAsk(ScreenName name)
        {
            YesButton.Visible = true;
            NoButton.Visible = true;
            switch (name)
            {
                case ScreenName.Retry:
                    AskRetryLabel.Visible = true;
                    break;
                case ScreenName.EndGame:
                    AskExitLabel.Visible = true;
                    break;
                case ScreenName.BackMenu:
                    BackToGameButton.Visible = false;
                    AskBackMenuLabel.Visible = true;
                    break;
                default: break;
            }
        }
        private void RemoveAsk(ScreenName name)
        {
            YesButton.Visible = false;
            NoButton.Visible = false;
            switch (name)
            {
                case ScreenName.Retry:
                    AskRetryLabel.Visible = false;
                    BackFramePicBox.Visible = false;
                    break;
                case ScreenName.EndGame:
                    AskExitLabel.Visible = false;
                    break;
                case ScreenName.BackMenu:
                    AskBackMenuLabel.Visible = false;
                    BackFramePicBox.Visible = false;
                    break;
                default: break;
            }
        }
        private void ShowRules(ScreenName name)
        {
            RulesMainLabel.Visible = true;
            RuleLabel.Visible = true;
            switch (name)
            {
                case ScreenName.Rules:
                    BackToMenuButton.Visible = true;
                    break;
                case ScreenName.Info:
                    BackFramePicBox.Visible = true;
                    BackToGameButton.Visible = true;
                    break;
                default: break;
            }
        }
        private void StartGameMode(int mode)
        {
            activeMode = mode;
            this.KeyPreview = true;
            Player1Label.Visible = false;
            BackFramePicBox.Visible = false;
            Player2Label.Visible = false;
            CountNLabel.Visible = false;
            StartMode1Button.Visible = false;
            StartMode2Button.Visible = false;
            Player1Box.Visible = false;
            Player2Box.Visible = false;
            TablePanelMode1.Visible = false;
            BackToChoiceModeButton.Visible = false;
            ShowGameField();
            CreatePlayersByName();
            MoveLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - MoveLabel.Width / 2, MoveLabel.Height * 3);
            LabelCountMove.Location = new System.Drawing.Point(ClientSize.Width / 2 - LabelCountMove.Width / 2, MoveLabel.Height * 2);
            infButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - ButtonFinishGame.Width / 2 - infButton.Width * 2, ButtonFinishGame.Location.Y);
            retryButton.Location = new System.Drawing.Point(ClientSize.Width / 2 + ButtonFinishGame.Width / 2 + retryButton.Width, ButtonFinishGame.Location.Y);

            verts = SproutsAlgorithms.CreatePoints(nVerts, this.ClientSize.Width, this.ClientSize.Height);
            DrawVerts();
            this.MouseUp += new MouseEventHandler(Sprouts_MouseUp);
        }
        private void StartMode1Button_Click(object sender, EventArgs e)
        {
            StartGameMode(1);
        }
        private void StartMode2Button_Click(object sender, EventArgs e)
        {
            StartGameMode(2);
        }
        private void Sprouts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                RemoveGameField(0);
                Graph.Clear(Color.MintCream);
                BackToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - BackToMenuButton.Width / 2, ClientSize.Height / 2 + BackToMenuButton.Height/2);
                BackToGameButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - BackToGameButton.Width / 2, BackToMenuButton.Location.Y - BackToGameButton.Height*2);
                BackToGameButton.Visible = true;
                BackToMenuButton.Visible = true;
                BackFramePicBox.Visible = true;
            }
        }
        private void RoolsButton_Click(object sender, EventArgs e)
        {
            RemoveMainMenu();
            BackToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - BackToMenuButton.Width / 2, ClientSize.Height / 2 + BackToMenuButton.Height * 6);
            ShowRules(ScreenName.Rules);
        }     
        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            BackToMenuButton.Visible = false;
            if (BackToGameButton.Visible)  ShowAsk(ScreenName.BackMenu);  //экран после нажатия esc во время игры
            else
            {
                if (RuleLabel.Visible) //просмотр правил
                {
                    RuleLabel.Visible = false;
                    RulesMainLabel.Visible = false;
                }
                else if (Mode1Button.Visible) //выбор режима
                {
                    RemoveChoiceMenu();
                }
                else //управление
                {
                    ControlLabel.Visible = false;
                    ControlTextLabel.Visible = false;
                    LabelWin.Visible = false;
                }
                Reset(ScreenName.BackMenu);
                BackToMainMenu();
            }                
        }
        private void ShowChoiceMenu()
        {
            Mode1Button.Visible = true;
            Mode2Button.Visible = true;
            BackToMenuButton.Visible = true;
            ModeLabel.Visible = true;
        }
        private void RemoveChoiceMenu()
        {
            ModeLabel.Visible = false;
            Mode1Button.Visible = false;
            Mode2Button.Visible = false;
            BackToMenuButton.Visible = false;
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            RemoveMainMenu();
            ModeLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - ModeLabel.Width/2, ClientSize.Height / 2 - ModeLabel.Height*3);
            Mode1Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - Mode1Button.Width / 2, ClientSize.Height / 2 - ModeLabel.Height);
            Mode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - Mode2Button.Width / 2, ClientSize.Height / 2);
            BackToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - Mode2Button.Width / 2, ClientSize.Height / 2 + ModeLabel.Height*3);
            ShowChoiceMenu();
        }      
        private void ClickOnButtonN(object sender, MouseEventArgs e)
        {
            if (prevButton != null)
            {
                prevButton.BackColor = Color.MintCream;
                prevButton.ForeColor = Color.FromArgb(0, 64, 0);
            }
            nVerts = TablePanelMode1.GetColumn((Control)sender) + 1; //так как нумерация с нуля
            Button currButton = (Control)sender as Button; //определение кнопки
            currButton.BackColor = (Color.SeaShell);
            currButton.ForeColor = Color.Maroon;
            prevButton = currButton;
        }
        private void ControlCellsN() //добавляет к каждой ячейке tablelayout возможность нажать на кнопку
        {
            foreach (Control button in TablePanelMode1.Controls)
            {
                button.MouseClick += new MouseEventHandler(ClickOnButtonN);
                button.BackColor = Color.MintCream;
            }
        }
        private void ShowParamsGame()
        {
            Player1Label.Visible = true;
            Player2Label.Visible = true;
            TablePanelMode1.Visible = true;
            CountNLabel.Visible = true;      
            Player1Box.Visible = true;
            Player2Box.Visible = true;
            BackToChoiceModeButton.Visible = true;
            switch (activeMode)
            {          
                case 1:
                    StartMode1Button.Visible = true;
                    break;
                case 2:
                    StartMode2Button.Visible = true; 
                    break;
                default: break;
            }
        }
        private void Mode1Button_Click(object sender, EventArgs e)
        {
            ControlCellsN();
            activeMode = 1;
            RemoveChoiceMenu();
            ShowParamsGame();
        }
        private void Mode2Button_Click(object sender, EventArgs e)
        {
            ControlCellsN();
            activeMode = 2;
            RemoveChoiceMenu();
            Player2Box.Text = "Компьютер";
            Player2Box.ReadOnly = true;
            ShowParamsGame();
        }
        private void BackToChoiceModeButton_Click(object sender, EventArgs e)
        {
            Player1Label.Visible = false;
            Player2Label.Visible = false;
            CountNLabel.Visible = false;
            StartMode1Button.Visible = false;
            Player1Box.Visible = false;
            Player2Box.Visible = false;
            TablePanelMode1.Visible = false;
            BackToChoiceModeButton.Visible = false;
            StartGameButton.Visible = false;
            StartMode2Button.Visible = false;
            Reset(ScreenName.BackMenu);
            ShowChoiceMenu();
        }    
        private void ControlButton_Click(object sender, EventArgs e)
        {
            RemoveMainMenu();
            ControlLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - ControlLabel.Width / 2, ClientSize.Height / 2 - ControlLabel.Height *3);
            ControlTextLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - ControlTextLabel.Width / 2, ControlLabel.Location.Y + ControlLabel.Height*2);
            BackToMenuButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - BackToMenuButton.Width / 2, ClientSize.Height / 2 + BackToMenuButton.Height * 6);
            ControlLabel.Visible = true;
            ControlTextLabel.Visible = true;
            BackToMenuButton.Visible = true;
        }
        private void RetryButton_Click(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            RemoveGameField(ScreenName.Retry);
            Graph.Clear(Color.MintCream);
            ShowAsk(ScreenName.Retry);         
        }
       private void YesButton_Click(object sender, EventArgs e)
        {
            if (AskRetryLabel.Visible)
            {
                RemoveAsk(ScreenName.Retry);
                ShowGameField();
                Reset(ScreenName.Retry);
            }
            else if(AskBackMenuLabel.Visible)
            {
                RemoveAsk(ScreenName.BackMenu);
                BackToMainMenu();
                Reset(ScreenName.BackMenu);
            }
            else if (AskExitLabel.Visible == true)
            {
                this.Close();
            }
        }
        private void NoButton_Click(object sender, EventArgs e)
        {
            if(AskRetryLabel.Visible)
            {
                RemoveAsk(ScreenName.Retry);
                ShowGameField();
                Redraw();
            }
            else if(AskBackMenuLabel.Visible)
            {
                RemoveAsk(ScreenName.BackMenu);
               
                ShowGameField();
                Redraw();
            }
            else if (AskExitLabel.Visible)
            {
                RemoveAsk(ScreenName.EndGame);
                BackToMainMenu();
            }
        }
      private void BackToGameButton_Click(object sender, EventArgs e)//возвращение к игре после просмотра правил
        {
            this.KeyPreview = true; //возможность снова нажимать esc
            BackFramePicBox.Visible = false;
            BackToGameButton.Visible = false;
            BackToMenuButton.Visible = false;
            RuleLabel.Visible = false;
            RulesMainLabel.Visible = false;
            ShowGameField();
            Redraw();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            RemoveMainMenu();
            ShowAsk(ScreenName.EndGame);      
        }
        private void Sprouts_Load(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            prevButton = n1;
            //основное меню
            GameNameLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - GameNameLabel.Width / 2, ClientSize.Height / 2 - GameNameLabel.Height * 2 + 50);
            StartGameButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - StartGameButton.Width / 2, ClientSize.Height / 2 - StartGameButton.Height / 2 - StartGameButton.Height);
            RulesButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - RulesButton.Width / 2, ClientSize.Height / 2);
            ControlButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - ControlButton.Width / 2, ClientSize.Height / 2 + ControlButton.Height / 2 + ControlButton.Height);
            ExitButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - ExitButton.Width / 2, ClientSize.Height / 2 + ExitButton.Height * 3);
            BackFramePicBox.Location = new System.Drawing.Point(0, 0);
            BackFramePicBox.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);
            WhileGamePicBox.Location = new System.Drawing.Point(0, 0);
            WhileGamePicBox.Size = new System.Drawing.Size(this.ClientSize.Width, MoveLabel.Location.Y);

            ButtonFinishGame.Location = new System.Drawing.Point(ClientSize.Width / 2 - ButtonFinishGame.Width / 2, ClientSize.Height - ButtonFinishGame.Height * 3);

            //режим 2 //размеры картинок
            StartMode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - StartMode1Button.Width / 2, ClientSize.Height / 2 + Player2Label.Height * 2);
            //сообщения об ошибках
            IntersectError.Location = new System.Drawing.Point(ClientSize.Width / 2 - IntersectError.Width / 2, ClientSize.Height / 2 - IntersectError.Height / 2);
            connectionError.Location = new System.Drawing.Point(ClientSize.Width / 2 - connectionError.Width / 2, ClientSize.Height / 2 - connectionError.Height / 2);

            //экраны подтверждений
            AskRetryLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - AskRetryLabel.Width / 2, ClientSize.Height / 2 - AskRetryLabel.Height);
            AskBackMenuLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - AskBackMenuLabel.Width / 2, ClientSize.Height / 2 - AskBackMenuLabel.Height);
            AskExitLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - AskExitLabel.Width / 2, ClientSize.Height / 2 - AskExitLabel.Height);
            YesButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - YesButton.Width * 3 / 2, ClientSize.Height / 2 + AskRetryLabel.Height);
            NoButton.Location = new System.Drawing.Point(ClientSize.Width / 2 + NoButton.Width / 2, ClientSize.Height / 2 + AskRetryLabel.Height);

            //выбор начальных параметров
            CountNLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - CountNLabel.Width / 2, ClientSize.Height / 4 + CountNLabel.Height);
            TablePanelMode1.Location = new System.Drawing.Point(ClientSize.Width / 2 - TablePanelMode1.Width / 2, CountNLabel.Location.Y + TablePanelMode1.Height);
            Player1Label.Location = new System.Drawing.Point(ClientSize.Width / 2 - Player1Label.Width * 3 / 2, TablePanelMode1.Location.Y + Player1Label.Height * 3);
            Player1Box.Location = new System.Drawing.Point(ClientSize.Width / 2 - Player1Box.Width - Player1Label.Width / 5, Player1Label.Location.Y + TablePanelMode1.Height);
            Player2Label.Location = new System.Drawing.Point(ClientSize.Width / 2 + Player2Label.Width / 2, TablePanelMode1.Location.Y + Player1Label.Height * 3);
            Player2Box.Location = new System.Drawing.Point(ClientSize.Width / 2 + Player2Box.Width / 6, Player2Label.Location.Y + TablePanelMode1.Height);
            StartMode1Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - StartMode1Button.Width / 2, ClientSize.Height / 2 + Player2Label.Height * 4);
            StartMode2Button.Location = new System.Drawing.Point(ClientSize.Width / 2 - StartMode2Button.Width / 2, ClientSize.Height / 2 + Player2Label.Height * 4);
            BackToChoiceModeButton.Location = new System.Drawing.Point(ClientSize.Width / 2 - StartMode1Button.Width / 2, ClientSize.Height / 2 + StartMode1Button.Height * 5);

            //правила
            RulesMainLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - RulesMainLabel.Width / 2, ClientSize.Height / 4);
            RuleLabel.Location = new System.Drawing.Point(ClientSize.Width / 2 - RuleLabel.Width / 2, RulesMainLabel.Location.Y + RulesMainLabel.Height * 3 / 2);
        }
    }
}

