using SproutsGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SproutsGame
{
    //internal class Event
    //{


    //    private int x; // координаты точки на заметающей прямой 
    //    private int y;
    //    private EventType eventType; // Добавлено для определения типа события
    //    private int segId; //номер сегмента, к которому принадлежит событие 

    //    public Event(int x, int y, EventType type,int segId)
    //    {
    //        X = x;
    //        Y = y;
    //        EventType = type;
    //        SegId = segId; 
    //    }

    //    public int X { get => x; set => x = value; }
    //    public int Y { get => y; set => y = value; }
    //    public EventType EventType { get => eventType; set => eventType = value; }
    //    public int SegId { get => segId; set => segId = value; }
    //}

    //internal enum EventType
    //{
    //    Start,
    //    End
    //}


    //internal class LineSegment
    //{
    //    public Event Start { get; set; }
    //    public Event End { get; set; }
    //    public int Id { get; set; }
    //    public LineSegment(Event start, Event end, int id)
    //    {
    //        Start = start;
    //        End = end;
    //        Id = id;
    //    }
    //}
}


//private bool checkIntersect(LineSegment a, LineSegment b)
//{
//    MyPen = new Pen(Color.Red, 7);
//    // Рисуем первый сегмент
//    Graph.DrawLine(MyPen, a.Start.X, a.Start.Y, a.End.X, a.End.Y);

//    MyPen = new Pen(Color.DarkBlue, 7);
//    // Рисуем второй сегмен
//    Graph.DrawLine(MyPen, b.Start.X, b.Start.Y, b.End.X, b.End.Y);

//    MyPen = new Pen(Color.Green, 7);
//    // Рисуем первый сегмент
//    Graph.DrawLine(MyPen, a.Start.X, a.Start.Y, a.End.X, a.End.Y);


//    MyPen = new Pen(Color.Green, 7);
//    // Рисуем второй сегмен
//    Graph.DrawLine(MyPen, b.Start.X, b.Start.Y, b.End.X, b.End.Y);

//    // Точки начала и конца первого отрезка
//    double r1X = a.Start.X;
//    double r1Y = a.Start.Y;
//    double r2X = a.End.X;
//    double r2Y = a.End.Y;

//    // Точки начала и конца второго отрезка
//    double p1X = b.Start.X;
//    double p1Y = b.Start.Y;
//    double p2X = b.End.X;
//    double p2Y = b.End.Y;

//    // Вычисление направляющих векторов отрезков
//    double v_rX = r2X - r1X;
//    double v_rY = r2Y - r1Y;
//    double v_pX = p2X - p1X;
//    double v_pY = p2Y - p1Y;

//    // Знаменатель в вычислении параметров t и t2
//    double denominator = v_rY * v_pX - v_rX * v_pY;

//    // Проверка параллельности отрезков
//    if (denominator == 0) return false;

//    // Вычисление параметров на основе формулы пересечения 
//    double t = ((p1X - r1X) * v_pY - (p1Y - r1Y) * v_pX) / denominator;
//    double t2 = ((r1X - p1X) * v_rY - (r1Y - p1Y) * v_rX) / -denominator;

//    // Проверка условий принадлежности точки пересечения обоим отрезкам
//    return (0 < t && t <= 1) || (0 < t2 && t2 <= 1);
//}

//    static int Orientation(Event a, Event b, Event c)
//    {
//        int val = (b.Y - a.Y) * (c.X - b.X) - (b.X - a.X) * (c.Y - b.Y);
//        if (val == 0) return 0; // Коллинеарны
//        return (val > 0) ? 1 : 2; // По часовой стрелке или против
//    }

//    private bool checkIntersect(LineSegment a, LineSegment b)
//    {
//        Event p1 = a.Start, q1 = a.End;
//        Event p2 = b.Start, q2 = b.End;

//        if ((p1.X == p2.X && p1.Y == p2.Y) ||
//(p1.X == q2.X && p1.Y == q2.Y) ||
//(q1.X == p2.X && q1.Y == p2.Y) ||
//(q1.X == q2.X && q1.Y == q2.Y))

//            return false;

//        MyPen = new Pen(Color.Red, 7);
//        // Рисуем первый сегмент
//        Graph.DrawLine(MyPen, a.Start.X, a.Start.Y, a.End.X, a.End.Y);

//        MyPen = new Pen(Color.DarkBlue, 7);
//        // Рисуем второй сегмен
//        Graph.DrawLine(MyPen, b.Start.X, b.Start.Y, b.End.X, b.End.Y);

//        MyPen = new Pen(Color.Green, 7);
//        // Рисуем первый сегмент
//        Graph.DrawLine(MyPen, a.Start.X, a.Start.Y, a.End.X, a.End.Y);


//        MyPen = new Pen(Color.Green, 7);
//        // Рисуем второй сегмен
//        Graph.DrawLine(MyPen, b.Start.X, b.Start.Y, b.End.X, b.End.Y);

//        // Проверка четырех ориентаций
//        int o1 = Orientation(p1, q1, p2);
//        int o2 = Orientation(p1, q1, q2);
//        int o3 = Orientation(p2, q2, p1);
//        int o4 = Orientation(p2, q2, q1);


//        if (o1 != o2 && o3 != o4) return true;



//        return false; 
//    }

//double GetYAtX(LineSegment segment, double x)
//{
//    // Вычисляем параметры a и b уравнения прямой вида y = ax + b через две точки
//    double dx = segment.End.X - segment.Start.X;
//    //Проверка на вертикальный сегмент, чтобы избежать деления на ноль
//    if (dx == 0) return segment.Start.Y;
//    double dy = segment.End.Y - segment.Start.Y;
//    double a = dy / dx;
//    double b = segment.Start.Y - a * segment.Start.X;

//    // Вычисляем и возвращаем Y для данного X
//    return a * x + b;
//}

//bool sweepLine()
//{
//    events.Sort((a, b) => a.X.CompareTo(b.X));

//    List<LineSegment> activeSegments = new List<LineSegment>();

//    bool intersect = false;
//    bool intersect2 = false;

//    for (int i = 0; i < events.Count; i++)
//    {
//        double sweepLineX = events[i].X;


//        if (events[i].EventType == EventType.Start)
//        {     
//           if (i + 1 < events.Count)
//            {
//                if (i == 0 && segments.Count > 1)
//                {

//                    intersect = checkIntersect(segments[events[i].SegId], segments[events[i + 1].SegId]);
//                }
//                else
//                {
//                    if (i > 0)
//                    {

//                        intersect = checkIntersect(segments[events[i].SegId], segments[events[i - 1].SegId]);

//                    }
//                    if (i + 1 < events.Count)
//                    {
//                        intersect2 = checkIntersect(segments[events[i].SegId], segments[events[i + 1].SegId]);
//                    }
//                }
//            }

//            if (!intersect && !intersect2)
//            {
//                LineSegment newSegment = segments[events[i].SegId];
//                // Находим позицию вставки перебором
//                int index = 0;
//                while (index < activeSegments.Count &&
//                       GetYAtX(activeSegments[index], sweepLineX) < GetYAtX(newSegment, sweepLineX))
//                {
//                    index++;
//                }
//                // Вставляем на найденную позицию
//                activeSegments.Insert(index, newSegment);
//            }
//            else return true;

//        }
//        else
//        {
//            if (i > 0 && i + 1 < events.Count)
//            {
//                intersect = checkIntersect(segments[events[i - 1].SegId], segments[events[i + 1].SegId]);
//            }
//            if (!intersect)
//                activeSegments.Remove(segments[events[i].SegId]);
//            else return true;

//        }
//    }
//    return false;
//}

// private int segmentCount = 0; // Общее число созданных сегментов
//Event e1 = null;

//private void splitPointsToSegments()
//{

//    for (int i = step; i < pointsXY.Count-step; i += step)
//    {
//        if (i + step > pointsXY.Count) break;

//        e1 = new Event(pointsXY[i].X, pointsXY[i].Y, EventType.Start, segmentCount);
//        events.Add(e1); //добавление начала сегмента в список сегментов

//        int endIndex = i + step;

//        Event e2 = new Event(pointsXY[endIndex].X, pointsXY[endIndex].Y, EventType.End, segmentCount);
//        events.Add(e2); // Добавление конца сегмента в список событий

//        LineSegment segment = new LineSegment(e1, e2, segmentCount);
//        segments.Add(segment); //список отрезков, которые надо будет проверять
//        segmentCount++;

//    }
//}


//private void splitPointsToSegments()
//{
//    List<Point> tmpPoints = new List<Point>();

//    tmpPoints.Add(pointsXY[0]);

//    for (int i = step; i < pointsXY.Count - step; i += step)
//    {
//        if (i + step > pointsXY.Count) break;

//        tmpPoints.Add(pointsXY[i]);

//        int endIndex = i + step;

//        tmpPoints.Add(pointsXY[endIndex]);

//    }
//    pointsXY= tmpPoints;

//    tmpPoints.Add(pointsXY[pointsXY.Count-1]);
//}