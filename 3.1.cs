using System;
class Program
{
    static void Main()
    {
        double m, s, p, g;
        Console.Write("введите ссуду под 20% годовых=");
        m = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите сумму долга s=");
        s = Convert.ToDouble(Console.ReadLine());
        g = 0;
        {
            while (m < s)
            {
                p = (m * 20) / 100;
                m = m + p;
                g = g + 1;
            }
            Console.WriteLine(+g);
            Console.ReadLine();
        }
    }
}
