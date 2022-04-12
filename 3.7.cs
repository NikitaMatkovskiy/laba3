using System;
class Program
{
    static void Main()
    {
        double m, s, p, g;
        Console.Write("первоначальная сумма вклада=");
        m = Convert.ToDouble(Console.ReadLine());
        Console.Write("какая сумма интересует?=");
        s = Convert.ToDouble(Console.ReadLine());
        g = 0;
        {
            while (m <= s)
            {
                p = (m * 2) / 100;
                m = m + p;
                g = g + 1;
            }
            Console.WriteLine("через  " + g);
            Console.ReadLine();
        }
    }
}
