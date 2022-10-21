internal class Program
{
    class Point
    {
        public double x, y, z;
        char name;
        public Point(double[] coordinates,char name)
        {
            x = coordinates[0];
            y = coordinates[1];
            z = coordinates[2];
            this.name = name;
        }
        public string Visual()
        {
            return $"{name}({x},{y},{z})";
        }
    }

    static double GetLenAB(Point A, Point B)
    {
        double length = Math.Sqrt(Math.Pow(B.x - A.x, 2) +
                                  Math.Pow(B.y - A.y, 2) +
                                  Math.Pow(B.z - A.z, 2));
        return length;
    }


    private static void Main(string[] args)
    {
        //исходные данные
        Point pointA = new Point(new double[] { 3, 6, 8 },'A');
        Point pointB = new Point(new double[] { 2, 1, -7 },'B');
        //расчет
        Console.WriteLine($"{pointA.Visual()};{pointB.Visual()} -> {GetLenAB(pointA, pointB),0:F2}");

        //исходные данные
        pointA = new Point(new double[] { 7, -5, 0 },'A');
        pointB = new Point(new double[] { 1, -1, -9 },'B');
        //расчет
        Console.WriteLine($"{pointA.Visual()};{pointB.Visual()} -> {GetLenAB(pointA, pointB),0:F2}");

    }
}