namespace pr4 {
    public class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point(-10F, -10.5F);
            IsInSquare(point);
        }

        public static void IsInSquare(Point point)
        {
            var (x, y) = point;
            if (x * x + y * y > 25*25 || y > 0 || (y > -Math.Abs(x) && x != 0))
            {
                Console.WriteLine("НЕТ");
            }
            else if (y < -Math.Abs(x))
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("На границе");
            }
        }
    }
}