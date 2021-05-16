using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        var points = new List<Point>();
        int k = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            var coordinates = Console.ReadLine().Split();
            int xi = int.Parse(coordinates[0]);
            int yi = int.Parse(coordinates[1]);

            double a = 0 - xi;
            double b = 0 - yi;
            double result = Math.Pow(a, 2) + Math.Pow(b, 2);
            double distance = Math.Sqrt(result);

            Point point = new Point(xi, yi, distance);
            if (!points.Contains(point))
            {
                points.Add(point);
            }
        }

        Point temp;
        for (int j = 0; j < points.Count - 1; j++)
        {
            for (int i = j + 1; i < points.Count; i++)
            {
                if (points[j].distance > points[i].distance)
                {
                    temp = points[j];
                    points[j] = points[i];
                    points[i] = temp;
                }
            }
        }

        List<Point> resultPoints = new List<Point>();
        for (int i = 0; i < k; i++)
        {
            resultPoints.Add(points[i]);
        }

        resultPoints = resultPoints.OrderBy(x => x.xi).ThenBy(y => y.yi).ToList();

        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("(" + resultPoints[i].xi + ", " + resultPoints[i].yi + ")");
        }
    }
}

public class Point
{
    public int xi { get; set; }
    public int yi { get; set; }
    public double distance { get; set; }
    public Point(int xi , int yi, double distance)
    {
        this.xi = xi;
        this.yi = yi;
        this.distance = distance;
    }
}