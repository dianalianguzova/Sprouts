using SproutsGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprouts
{
    internal class Edge
    {
        List<Point> pointsXY; //координаты линии 
        int countPoints = 0;
        public Edge(List<Point>pointsXY_) {
            this.getPointsList = pointsXY_;          
        }
        public List<Point> getPointsList { get => pointsXY; set => pointsXY = value; }
        public int CountPoints { get => countPoints; set => countPoints = value; }

        public Point this[int index] //индексатор
        {
            get
            {
                return pointsXY[index];
            }
            set
            {
                pointsXY[index] = value;
            }
        }

        public void clear()
        {
            pointsXY.Clear();
        }
        public bool findBoundaryPoints(Vert v1, Vert v2, int radius) //нахождение граничных точек линий с окружностями, которая станет вторым элементом массива 
        {
            //изменение начальной и конечной точки: при проверке соединений линий, если их можно соединить, то начало и конец будут лежать в центре окружностей
            Point p = pointsXY[0];
            p.X = v1.X + radius / 2;
            p.Y = v1.Y + radius / 2;
            pointsXY[0] = p;

            p.X = v2.X + radius / 2;
            p.Y = v2.Y + radius / 2;
            pointsXY[pointsXY.Count - 1] = p;

            int i = 1;
            while (i < pointsXY.Count)
            {
                if (Math.Sqrt(Math.Pow(pointsXY[i].X - pointsXY[0].X, 2) + Math.Pow(pointsXY[i].Y - pointsXY[0].Y, 2)) < radius) i++;
                else break;
            }
            pointsXY.RemoveRange(1, i - 1);

            i = pointsXY.Count - 2;
            while (i >= 0)
            {
                if (Math.Sqrt(Math.Pow(pointsXY[i].X - pointsXY[pointsXY.Count - 1].X, 2) + Math.Pow(pointsXY[i].Y - pointsXY[pointsXY.Count - 1].Y, 2)) < radius) i--;
                else break;
            }
            if (i > 0)
            { //предотвращение исключения, если линия нарисована внутри одной вершины
                pointsXY.RemoveRange(i, pointsXY.Count - 1 - i);
                getPointsList = pointsXY;
                return true;
            }
            return false;
        }

    }
}
