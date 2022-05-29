namespace Seminars
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class LinqSecond
    {
        public Point[] points = new Point[] { new Point(0, 0), new Point(0, 1) };

        public List<Point> SecondMain()
        {
            var integers = new[] { 0, -1, 1 };
            return points
                .Select(z => integers
                .SelectMany(x => integers
                .Select(y => new Point(z.X + x, z.Y + y))))
                .SelectMany(x => x)
                .ToHashSet()
                .Distinct()
                .ToList();
        }
    }
}
