using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprouts;
using SproutsGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;


namespace UnitTestSprouts
{
    [TestClass]
    public class UnitTestSprouts
    {
        public static IEnumerable<object[]> EdnpointValuesOfIntersectingSegments() //рандомные пересекающиеся отрезки
        {
            yield return new object[] { new Point(0,1), new Point(2,3), new Point(-1,4), new Point(5,0) };
            yield return new object[] { new Point(-3, 4), new Point(0, 4), new Point(-1,6), new Point(0,-2)};
            yield return new object[] { new Point(0,0), new Point(1, 6), new Point(5, -2), new Point(-1, 2)};
            yield return new object[] { new Point(0, 0), new Point(1, 6), new Point(0, 5), new Point(2,-2)};
            yield return new object[] { new Point(-3, 2), new Point(0, 2), new Point(-2, -1), new Point(-1, 4) };
        }

        [DataTestMethod]
        [DynamicData(nameof(EdnpointValuesOfIntersectingSegments), DynamicDataSourceType.Method)]
        public void CheckSegmentsIntersectTest_ReturnTrue(Point x1, Point y1, Point x2, Point y2)
        {
           bool isIntersect = SproutsAlgorithms.CheckIntersect(x1,y1,x2,y2);
           Assert.IsTrue(isIntersect);
        }

        public static IEnumerable<object[]> SameEdnpointValuesOfIntersectingSegments() //пересечения отрезков, которые имеют одинаковые конечные точки
        {
            yield return new object[] { new Point(0, 1), new Point(2, 3), new Point(0,1), new Point(-1, 2) };
            yield return new object[] { new Point(-3, 4), new Point(0, 4), new Point(-1, 6), new Point(-3, 4) };
            yield return new object[] { new Point(0, 0), new Point(1, 6), new Point(0, 0), new Point(-1, 2) };
            yield return new object[] { new Point(0, 0), new Point(1, 6), new Point(0, 5), new Point(1, 6) };
           yield return new object[] { new Point(-3, 2), new Point(0, 2), new Point(-3, 2), new Point(0, 2) };// одинаковые отрезки
        }

        [DataTestMethod]
        [DynamicData(nameof(SameEdnpointValuesOfIntersectingSegments), DynamicDataSourceType.Method)]
        public void CheckSegmentsSameEndpointsIntersectTest_ReturnTrue(Point x1, Point y1, Point x2, Point y2)
        {
            bool isIntersect = SproutsAlgorithms.CheckIntersect(x1, y1, x2, y2);
            Assert.IsTrue(isIntersect);
        }

        public static IEnumerable<object[]> EdnpointValuesOfParallelSegments() //проверка параллельных отрезков
        {
            yield return new object[] { new Point(1, 5), new Point(0, 4), new Point(0, 5), new Point(-1, 4) };
            yield return new object[] { new Point(0, 4), new Point(0, 6), new Point(1, 2), new Point(1, 7) };
            yield return new object[] { new Point(2, 4), new Point(1, 4), new Point(1, 2), new Point(6, 2) };
            yield return new object[] { new Point(2, 5), new Point(1, 4), new Point(1, 2), new Point(2, 3) };
            yield return new object[] { new Point(0, 2), new Point(2, 0), new Point(2, 4), new Point(4, 2) };
        }

        [DataTestMethod]
        [DynamicData(nameof(EdnpointValuesOfParallelSegments), DynamicDataSourceType.Method)]
        public void CheckParallelSegmentsTest_ReturnFalse(Point x1, Point y1, Point x2, Point y2)
        {
            bool isIntersect = SproutsAlgorithms.CheckIntersect(x1, y1, x2, y2);
            Assert.IsFalse(isIntersect);
        }

        public static IEnumerable<object[]> EdnpointValuesOfNonIntersectingSegments() //рандомные непересекающиеся отрезки
        {
            yield return new object[] { new Point(-1, 3), new Point(0, 2), new Point(2, 4), new Point(0, 4) };
            yield return new object[] { new Point(-1, 6), new Point(0, 2), new Point(3, 4), new Point(0, 4) };
            yield return new object[] { new Point(0, 0), new Point(1,3), new Point(0, 2), new Point(0, 3) };
            yield return new object[] { new Point(-1, 4), new Point(1, 5), new Point(0, 4), new Point(-2, 3) };
            yield return new object[] { new Point(1, 4), new Point(2, 6), new Point(0, 4), new Point(4, 9) };
        }

        [DataTestMethod]
        [DynamicData(nameof(EdnpointValuesOfNonIntersectingSegments), DynamicDataSourceType.Method)]
        public void CheckNonIntersectSegmentsTest_ReturnFalse(Point x1, Point y1, Point x2, Point y2)
        {
            bool isIntersect = SproutsAlgorithms.CheckIntersect(x1, y1, x2, y2);
            Assert.IsFalse(isIntersect);
        }

        public static IEnumerable<object[]> EdnpointValuesOfIntersectingSegmentsLiesOnAnother() //пересечение отрезков, когда конец одного лежит на другом 
        {
            yield return new object[] { new Point(0, 1), new Point(2, 4), new Point(0, 4), new Point(1, 2) };
            yield return new object[] { new Point(-1, 6), new Point(2, 6), new Point(1, 6), new Point(1, 5) };
            yield return new object[] { new Point(0, 4), new Point(0, 0), new Point(0, 2), new Point(1, 5) };
            yield return new object[] { new Point(-1, 4), new Point(1, 2), new Point(0, 3), new Point(0,0) };
            yield return new object[] { new Point(1, 3), new Point(0, 2), new Point(-1, 3), new Point(2, 0) };
        }

        [DataTestMethod]
        [DynamicData(nameof(EdnpointValuesOfIntersectingSegmentsLiesOnAnother), DynamicDataSourceType.Method)]
        public void CheckLiesOnAnotherIntersectSegmentsTest_ReturnTrue(Point x1, Point y1, Point x2, Point y2)
        {
            bool isIntersect = SproutsAlgorithms.CheckIntersect(x1, y1, x2, y2);
            Assert.IsTrue(isIntersect);
        }

        public static IEnumerable<object[]> RightDegreesOfVerts() //проверка соединения двух разных вершин с соотв. степенями
        {
            yield return new object[] { 0, 0 };
            yield return new object[] { 0,1 };
            yield return new object[] {1,0 };
            yield return new object[] { 1,1 };
            yield return new object[] { 0,2};
            yield return new object[] {1,2 };
            yield return new object[] {2,0 };
            yield return new object[] {2,1 };
            yield return new object[] { 2, 2 };
        }

        [DataTestMethod]
        [DynamicData(nameof(RightDegreesOfVerts), DynamicDataSourceType.Method)]
        public void CheckDegreesVerts_ReturnTrue(int a, int b)
        {
            Vert v1 = new Vert(0, 0, a), v2 = new Vert(1, 1, b);
            bool checkDegrees = SproutsAlgorithms.CheckVertexLines(v1,v2);
            Assert.IsTrue(checkDegrees);
        }


        public static IEnumerable<object[]> RightDegreeOfVert() //проверка соединения петли с соотв. степенью
        {
            yield return new object[] {0};
            yield return new object[] { 1 };
        }
        [DataTestMethod]
        [DynamicData(nameof(RightDegreeOfVert), DynamicDataSourceType.Method)]
        public void CheckDegreeOneVert_ReturnTrue(int a)
        {
            Vert v1 = new Vert(0, 0, a), v2 = v1;
            bool checkDegrees = SproutsAlgorithms.CheckVertexLines(v1, v2);
            Assert.IsTrue(checkDegrees);
        }

        public static IEnumerable<object[]> WrongDegreesOfVerts() //проверка соединения двух разных вершин с соотв. степенями
        {
            yield return new object[] { 0, 3};
            yield return new object[] { 3, 0 };
            yield return new object[] { 1, 3 };
            yield return new object[] { 3, 1 };
            yield return new object[] { 2, 3 };
            yield return new object[] { 3, 2 };
            yield return new object[] { 3, 3 };
        }

        [DataTestMethod]
        [DynamicData(nameof(WrongDegreesOfVerts), DynamicDataSourceType.Method)]
        public void CheckDegreesVerts_ReturnFalse(int a, int b)
        {
            Vert v1 = new Vert(0, 0, a), v2 = new Vert(1, 1, b);
            bool checkDegrees = SproutsAlgorithms.CheckVertexLines(v1, v2);
            Assert.IsFalse(checkDegrees);
        }

        public static IEnumerable<object[]> WrongDegreeOfVert() //проверка соединения петли с соотв. степенью
        {
            yield return new object[] { 2 };
            yield return new object[] { 3 };
        }
        [DataTestMethod]
        [DynamicData(nameof(WrongDegreeOfVert), DynamicDataSourceType.Method)]
        public void CheckDegreeOneVert_ReturnFalse(int a)
        {
            Vert v1 = new Vert(0, 0, a), v2 = v1;
            bool checkDegrees = SproutsAlgorithms.CheckVertexLines(v1, v2);
            Assert.IsFalse(checkDegrees);
        }

        public static IEnumerable<object[]> CorrectVerts() 
        {           
            yield return new object[] {128, 134, 120, 110}; //граничная первой
            yield return new object[] {128, 133, 120, 110}; //внутри
            yield return new object[] {112, 118, 120, 110}; //граничная первой
            yield return new object[] {113, 118, 120, 110}; //внутри
            yield return new object[] {28, -98, 20, -90}; //граничная второй
            yield return new object[] {28, -97, 20, -90}; //внутри
            yield return new object[] {38, 54, 30, 30}; //граничная третьей
            yield return new object[] {38, 53, 30, 30}; //внутри
        }

        [DataTestMethod]
        [DynamicData(nameof(CorrectVerts), DynamicDataSourceType.Method)]
        public void CheckFindVertex_CorrectVert( int a, int b, int ansX,int ansY)
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(120, 110, 0),
                new Vert(20, -90, 0),
                new Vert(30, 30, 0)
            };
            Vert vertex = SproutsAlgorithms.FindVertex(a, b, verts); 

            Assert.AreEqual(ansX, vertex.X);
            Assert.AreEqual(ansY, vertex.Y);
        }

        public static IEnumerable<object[]> IncorrectVerts()
        {
            yield return new object[] { 128, 135 }; //все вне границы 
            yield return new object[] { 129, 134 };
            yield return new object[] { 111, 118 }; //первая
            yield return new object[] { 112, 119 };
            yield return new object[] { 29, -98 }; //вторая
            yield return new object[] { 28, -99 };
            yield return new object[] { 37, 54 }; //третья
            yield return new object[] { 38, 55 };
        }

        [DataTestMethod]
        [DynamicData(nameof(IncorrectVerts), DynamicDataSourceType.Method)]
        public void CheckFindVertex_IncorrectVert(int a, int b)
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(120, 110, 0),
                new Vert(20, -90, 0),
                new Vert(30, 30, 0)
            };
            Vert vertex = SproutsAlgorithms.FindVertex(a, b, verts);

            Assert.AreEqual(null, vertex);
        }

        public static IEnumerable<object[]> VertsMove()
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(200, 400, 0),
                new Vert(300, 300, 0),
                new Vert(400, 100, 0),
                new Vert(100, 100, 0)
            };
            yield return new object[] { verts, 8};
        }

        [DataTestMethod]
        [DynamicData(nameof(VertsMove), DynamicDataSourceType.Method)]
        public void CheckRightMove_ErrorNone_1(List<Vert> verts, int radius)
        {
            int x = verts[0].X + radius;  
            int y = verts[0].Y + radius;
            List<Point> points = new List<Point>
            { new Point(x, y) };
            List<List<Point>> allCoords = new List<List<Point>>();

            while (x != verts[1].X + radius && y != verts[1].Y+ radius) //линия между первой и второй
            {
                x++; y--;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[2].X; 
            y = verts[2].Y;
            points.Clear();
            points.Add(new Point(x, y));
            while (x != verts[3].X) //линия между третьей и четвертой
            {
                x--;
                points.Add(new Point(x, y));
            }
            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, allCoords);
            Assert.AreEqual(ErrorType.None, error);
        }

        [DataTestMethod]
        [DynamicData(nameof(VertsMove), DynamicDataSourceType.Method)]
        public void CheckRightMove_ErrorNone_2(List<Vert> verts, int radius)
        {
            List<List<Point>> allCoords = new List<List<Point>>();
            int x = verts[0].X + radius;
            int y = verts[0].Y + radius;
            List<Point> points = new List<Point>
            { new Point(x, y) };
            while (x != verts[1].X + radius && y != verts[1].Y + radius) //линия между первой и второй
            {
                x++; y--;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[1].X;
            y = verts[1].Y;
            points.Clear();
            points.Add(new Point(x, y));
            while (x != verts[3].X && y != verts[3].Y) //линия между второй и четвертой
            {
                x--; y--;
                points.Add(new Point(x, y));
            }
            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, allCoords);
            Assert.AreEqual(ErrorType.None, error);
        }

        [DataTestMethod]
        [DynamicData(nameof(VertsMove), DynamicDataSourceType.Method)]
        public void CheckRightMove_ErrorNone_3(List<Vert> verts, int radius)
        {
            List<List<Point>> allCoords = new List<List<Point>>();
            int x = verts[0].X + radius;
            int y = verts[0].Y + radius;
            List<Point> points = new List<Point>
            { new Point(x, y) };
            while (x != verts[1].X + radius && y != verts[1].Y + radius) //линия между первой и второй
            {
                x++; y--;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[1].X + radius;
            y = verts[1].Y + radius;
            points.Clear();
            points.Add(new Point(x, y));
            while (x != verts[3].X + radius && y != verts[3].Y + radius) //линия между второй и четвертой
            {
                x--; y--;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[1].X; //вторая
            y = verts[1].Y;
            points.Clear();
            points.Add(new Point(x, y));
            while (x != verts[2].X && y != verts[2].Y) //линия между второй и третьей
            {
                x++; y -= 2;
                points.Add(new Point(x, y));
            }
            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, allCoords);
            Assert.AreEqual(ErrorType.None, error);
        }

        [TestMethod]
        public void CheckRightMove_ErrorIntersect_1()
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(100, 100, 0),
                new Vert(200, 400, 0),
                new Vert(300, 50, 0),
                new Vert(400, 100, 0)
            };
            int radius = 8;

            List<List<Point>> allCoords = new List<List<Point>>();
            int x = verts[1].X + radius;
            int y = verts[1].Y + radius;
            List<Point> points = new List<Point>
            { new Point(x, y) };
            while (x != verts[2].X + radius && y != verts[2].Y + radius) //линия между второй и третьей
            {
                x++; y -= 4;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[0].X;
            y = verts[0].Y;
            points.Clear();
            points.Add(new Point(x, y));
            while (x != verts[3].X) //линия между первой и четвертой (пересекает)
            {
                x += 2;
                points.Add(new Point(x, y));
            }

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, allCoords);
            Assert.AreEqual(ErrorType.Intersection, error);
        }

        public static IEnumerable<object[]> VertsMove2()
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(200, 400, 0),
                new Vert(300, 300, 0),
                new Vert(400, 100, 0),
                new Vert(100, 100, 0)
            };
            yield return new object[] { verts};
        }

        [DataTestMethod]
        [DynamicData(nameof(VertsMove), DynamicDataSourceType.Method)]
        public void CheckRightMove_ErrorIntersect_2(List<Vert> verts, int radius)
        {
            int x = verts[3].X;
            int y = verts[3].Y;
            List<Point> points = new List<Point>
            { new Point(x, y) };
            while (x != 300) //петля-самопересечение между второй и четвертой
            {
                x++;
                points.Add(new Point(x, y));
            }

            while (x != 200 && y != 50)
            {
                x -= 2; y--;
                points.Add(new Point(x, y));
            }

            while (x != verts[1].X && y != verts[1].Y)
            {
                x+=10; y += 25;
                points.Add(new Point(x, y));
            }

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, null);
            Assert.AreEqual(ErrorType.Intersection, error);
        }

        [DataTestMethod]
        [DynamicData(nameof(VertsMove), DynamicDataSourceType.Method)]
        public void CheckRightMove_ErrorIntersect_3(List<Vert> verts, int radius)
        {
            List<List<Point>> allCoords = new List<List<Point>>();
            int x = verts[2].X + radius;
            int y = verts[2].Y + radius;
            List<Point> points = new List<Point>
            { new Point(x, y) };
            while (x != 268 && y != 248) //петля (третья вершина)
            {
                x--; y++;
                points.Add(new Point(x, y));
            }

            while (x != 250 && y != 392)
            {
                x--; y += 8;
                points.Add(new Point(x, y));
            }

            while (x != 340)
            {
                x++;
                points.Add(new Point(x, y));
            }

            while (x != verts[2].X + radius && y != verts[2].Y + radius)
            {
                x += 17; y -= 71;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[0].X;
            y = verts[0].Y;
            points.Clear();
            points.Add(new Point(x, y));

            while (x != verts[1].X && y != verts[1].Y) //линия между первой и второй через петлю
            {
                x++; y--;
                points.Add(new Point(x, y));
            }

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, allCoords);
            Assert.AreEqual(ErrorType.Intersection, error);
        }

        [TestMethod]
        public void CheckRightMove_ErrorIntersect_4()
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(100, 100, 0),
                new Vert(200, 400, 0),
                new Vert(410, -20, 0),
                new Vert(400, 100, 0)
            };
            int radius = 8;
            List<List<Point>> allCoords = new List<List<Point>>();

            int x = verts[0].X+ radius;
            int y = verts[0].Y+ radius;
            List<Point> points = new List<Point>{ new Point(x, y) };

            while (x != verts[3].X + radius) //линия между первой и четвертой
            {
                x++;
                points.Add(new Point(x, y));
            }
            allCoords.Add(new List<Point>(points));

            x = verts[1].X;
            y = verts[1].Y;
            points.Clear();
            points.Add(new Point(x, y));

            while (x != verts[2].X && y != verts[2].Y) //линия между второй и третьей через граничную точку
            {
                x++; y-=2;
                points.Add(new Point(x, y));
            }

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, allCoords);
            Assert.AreEqual(ErrorType.Intersection, error);
        }

        [TestMethod]
        public void CheckRightMove_ErrorConnection_1()
        {
            List<Vert> verts = new List<Vert>
            {
                new Vert(200, 400, 1),
                new Vert(300, 300, 3),
                new Vert(400, 100, 1),
                new Vert(100, 100, 1),
                new Vert(400, 400, 0)
            };
            List<Point> points = new List<Point>();

            int x = verts[4].X;
            int y = verts[4].Y;
            points.Clear();
            points.Add(new Point(x, y));

            while (x != verts[1].X && y != verts[1].Y) //линия между четвертой и второй
            {
                x-=2; y-=2;
                points.Add(new Point(x, y));
            }

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, null);
            Assert.AreEqual(ErrorType.Connection, error);
        }

        [TestMethod]
        public void CheckRightMove_ErrorConnection_2()
        {
            List<Vert> verts = new List<Vert> {new Vert(300, 300, 2) };
            List<Point> points = new List<Point>();

            int x = verts[0].X;
            int y = verts[0].Y;
            points.Clear();
            points.Add(new Point(x, y)); //петля
            points.Add(new Point(280,320));
            points.Add(new Point(300, 340));
            points.Add(new Point(320, 320));
            points.Add(new Point(verts[0].X, verts[0].Y));

            ErrorType error = SproutsAlgorithms.CheckCorrectMove(verts, ref points, null);
            Assert.AreEqual(ErrorType.Connection, error);
        }
    }
}
