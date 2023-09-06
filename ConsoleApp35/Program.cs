using System.Security.Cryptography.X509Certificates;

public class Rhombus
{
    double a, b;

    public Rhombus()

    { }
    public Rhombus(double x, double y)
    { a = x; b = y; }
    public void Print()


    { Console.WriteLine("a={0} b={1}", a, b); }


    public double Area()
    {
        double p = (a * b)/2;
        return p;
    }


    public double Side()
    {
        double s = Math.Sqrt(Math.Pow(a/2,2) + Math.Pow(b/2,2));
        return s;
    }

    public bool Correct()
    {
        bool p = false;
        if (a > 0 && b > 0) p = true;
        return p;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double x, y;
        try
        {


            Console.WriteLine("x="); x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y="); y = Convert.ToDouble(Console.ReadLine());

            Rhombus t = new Rhombus(x, y);

            t.Print();
            if (t.Correct())
            {
                double p = t.Area();
                double s = t.Side();
                Console.WriteLine("P={0} side={1:F3}", p, s);
            }
            else Console.WriteLine("Такого ромба не существует");
        }
        catch
        {
            Console.WriteLine("Ошибка!!!");
        }
    }
}