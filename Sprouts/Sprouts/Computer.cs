using SproutsGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SproutsGame
{
    internal class Computer
    {
        public static List<Point> ComputerMove(List<Vert>verts, List<List<Point>> coordinatesAllPointsXY)
        {
            for (int i = 0; i < verts.Count - 1; i++)
            {
                Vert vertex1 = verts[i];
                if (verts[i].Lines <= 2)
                {
                    for (int j = i + 1; j < verts.Count; j++)
                    {
                        if (verts[j].Lines <= 2)
                        {
                            Vert vertex2 = verts[j];
                            List<Point>points = FindBoundaryPointsOfCompLine(vertex1, vertex2);
                            bool canComputerDrawLine = CheckCorrectMove(vertex1, vertex2, points, coordinatesAllPointsXY);
                            if (canComputerDrawLine) return points;              
                        }
                    }
                }
            }
            return new List<Point>();
        }

        private static bool CheckCorrectMove(Vert vertex1, Vert vertex2, List<Point> pointsXY, List<List<Point>> coordinatesAllPointsXY)
        {
            if (SproutsAlgorithms.Intersect(pointsXY, coordinatesAllPointsXY, ActivePlayer.Computer)) 
                return false;
            SproutsAlgorithms.UpdateVertexLines(vertex1, vertex2);
            return true;
        }

        private static List<Point> FindBoundaryPointsOfCompLine(Vert vertex1, Vert vertex2)
        {
            List<Point> points = new List<Point>();
            Random rand = new Random();
            int a = 0, b = 0;
            int x1 = vertex1.X + CommonVariable.radius;
            int y1 = vertex1.Y + CommonVariable.radius;
            int x2 = vertex2.X + CommonVariable.radius;
            int y2 = vertex2.Y + CommonVariable.radius;
            points.Add(new Point(x1, y1));

            int sx = x1 < x2 ? CommonVariable.radius : -CommonVariable.radius; //точки граничные c вершиной
            int sy = y1 < y2 ? CommonVariable.radius : -CommonVariable.radius;

            if (SproutsAlgorithms.DistBetweenTwoVerts(x1, y1, x2, y2) >= CommonVariable.minDistBetweenVerts)
            {
                a = rand.Next(-30, 30);//угол рандомный
                b = rand.Next(-30, 30);
            }
            else
            {
                a = rand.Next(-5, 5);
                b = rand.Next(-5, 5);
            }
            points.Add(new Point(x1 + sx, y1 + sy));
            points.Add(new Point((x2 + x1) / 2 + a, (y1 + y2) / 2 + b)); //серединная точка 
            sx = -sx; sy = -sy;
            points.Add(new Point(x2 + sx, y2 + sy));
            points.Add(new Point(x2, y2));
            return points;
        }
    }
}
