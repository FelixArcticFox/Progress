namespace Площадь
{
    class Geometry
    {
        public double Triangle(double b,double h)
        {
            b = b / 2;
            return b * h;
        }
        public int Square(int a)
        {
            return a * a;
        }
        public int Rectangle(int a,int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
        }
    }
}
