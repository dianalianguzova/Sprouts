using SproutsGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace SproutsGame
{
     internal class SproutsAlgorithms
     {      
        public static double DistBetweenTwoVerts(int v1, int w1, int v2, int w2)
        {
            return Math.Sqrt(Math.Pow(v2 - v1, 2) + Math.Pow(w2 - w1, 2));
        }
        public static List<Vert> CreatePoints(int nVerts, int width, int height)//cоздание точек
        {
            List<Vert> verts= new List<Vert>();
            Random rand = new Random();
            bool collision = true;
            int x = 0, y = 0;
            for (int i = 0; i < nVerts; i++)
            {
                while (collision)//проверка на то, чтобы нарисованные вершины не пересекались
                {
                    collision = false;
                    x = rand.Next(width / 4, width - width / 4);
                    y = rand.Next(height / 4, height - height / 4);
                    foreach (Vert point in verts)
                    {
                        if (DistBetweenTwoVerts(x, y, point.X, point.Y) < CommonVariable.minDistBetweenVerts)
                        {
                            collision = true; break;
                        }
                    }
                }
                collision = true;
                verts.Add(new Vert(x, y, 0));
            }
            return verts;
        }

        public static bool Intersect(List<Point> pointsXY, List<List<Point>> coordinatesAllPointsXY, ActivePlayer player)
        {
            if (player==ActivePlayer.Player)//проверка на самопересечение
            {
                for (int i = 0; i < pointsXY.Count; i++)
                {
                    for (int j = i + 2; j < pointsXY.Count - 2; j++) //шаг + 2, чтобы случай, когда конец одной - начало другой не проверялся
                    {
                        if (CheckIntersect(pointsXY[i], pointsXY[i + 1], pointsXY[j], pointsXY[j + 1])) return true;
                    }
                }
            }
            for (int i = 1; i < pointsXY.Count - 2; i++)
            {
                Point newLineA = pointsXY[i]; 
                Point newLineB = pointsXY[i + 1];
                foreach (var segment in coordinatesAllPointsXY)
                {
                    for (int j = 1; j < segment.Count - 2; j++)
                    {
                        Point prevLineA = segment[j];
                        Point prevLineB = segment[j + 1];
                        if (CheckIntersect(newLineA, newLineB, prevLineA, prevLineB)) return true;
                    }
                }
            }       
            return false;
        }
        public static bool CheckVertexLines(Vert vertex1, Vert vertex2)
        {
            return ((vertex1 == vertex2 && vertex1.Lines <= 1) || (vertex1 != vertex2 && vertex1.Lines <= 2 && vertex2.Lines <= 2));
        }

        public static Vert FindVertex(int x, int y, List<Vert> verts) //поиск соединяемой вершины
        {
            foreach (Vert searchVert in verts)
            {
                double distanceToVertex = DistBetweenTwoVerts(x, y, searchVert.X + CommonVariable.radius, searchVert.Y + CommonVariable.radius);
                if (distanceToVertex <= CommonVariable.radius *2)
                    return searchVert;              
            }
            return null;
        }

        public static ErrorType CheckCorrectMove(List<Vert> verts, ref List<Point>pointsXY, List<List<Point>> coordinatesAllPointsXY)
        {
            Vert v1 = FindVertex(pointsXY[0].X, pointsXY[0].Y, verts);
            Vert v2 = FindVertex(pointsXY[pointsXY.Count - 1].X, pointsXY[pointsXY.Count - 1].Y, verts);
     
            if (v1 != null && v2!= null)
            {
                if (!CheckVertexLines(v1, v2)) //если степени не соответствующие
                {
                    return ErrorType.Connection;
                }
                pointsXY = FindBoundaryPointsOfLine(v1.X, v1.Y, v2.X, v2.Y, pointsXY);
                if (pointsXY.Count!=0)
                {
                    if (Intersect(pointsXY, coordinatesAllPointsXY, ActivePlayer.Player))
                    {
                        return ErrorType.Intersection;
                    }
                }
                else return ErrorType.Other;

                UpdateVertexLines(v1,v2);
                return ErrorType.None;
            }
            return ErrorType.Other;
        }

        public static void UpdateVertexLines(Vert vertex1, Vert vertex2) //обновление степеней вершин
        {
            if (vertex1 == vertex2) //петля
            {
                vertex1.Lines += 2;
            }
            else 
            {
                vertex1.Lines++;
                vertex2.Lines++;
            }
        }
        public static bool CheckIntersect(Point r1, Point r2, Point p1, Point p2)
        {
            if (r1 == p1 && r2 == p2) return true; //отрезки совпадают

            //координаты направления вектора первого и второго отрезков
            double v = r2.X - r1.X;
            double w = r2.Y - r1.Y;
            double v2 = p2.X - p1.X;
            double w2 = p2.Y - p1.Y;

            //знаменатель в вычислении параметров t и t2
            double denominator = w * v2 - v * w2;
            if (denominator == 0) return false; //параллельность

            //вычисление параметров на основе формулы пересечения
            double t2 = (v * (p1.Y - r1.Y) - w * (p1.X - r1.X)) / denominator;
            double t = (v2 * (p1.Y - r1.Y) - w2 * (p1.X - r1.X)) / denominator;

            return !(t < 0 || t > 1 || t2 < 0 || t2 > 1);
        }
        private static List<Point> FindBoundaryPointsOfLine(int x1, int y1, int x2, int y2, List<Point> pointsXY) //нахождение граничных точек линий с окружностями, которая станет вторым элементом массива 
        {
            try { 
                List<Point> newPoints = new List<Point>();
                //изменение начальной и конечной точки: при проверке соединений линий, если их можно соединить, то начало и конец будут лежать в центре окружностей
                Point p = new Point();
                p.X = x1 + CommonVariable.radius;
                p.Y = y1 + CommonVariable.radius;
                newPoints.Add(p);
                              
                int i = 0;
                while (DistBetweenTwoVerts(pointsXY[i].X, pointsXY[i].Y, p.X, p.Y) <= CommonVariable.radius)
                {
                    i++;
                }
                p.X = x2 + CommonVariable.radius;
                p.Y = y2 + CommonVariable.radius;
                int j = pointsXY.Count - 1;
                while (DistBetweenTwoVerts(pointsXY[j].X, pointsXY[j].Y, p.X, p.Y) <= CommonVariable.radius)
                {
                    j--;
                }
                for (int k = i+1; k < j; k++)
                {
                    newPoints.Add(pointsXY[k]);
                }            
                newPoints.Add(p);
                return newPoints;
            }
            catch
            {
                return new List<Point>();
            }          
        }

        public static Vert CreateMiddlePoint(List<Point> pointsXY)//создание новой точки, которая лежит на середине линии
        {
            int xNewVert = pointsXY[(pointsXY.Count - 1) / 2].X - CommonVariable.radius; 
            int yNewVert = pointsXY[(pointsXY.Count - 1) / 2].Y - CommonVariable.radius;
            Vert newVert = new Vert(xNewVert, yNewVert, 2);
            return newVert;
        }
    }
}
