using System;
class Program
{
    static void Main()
    {
        double a, b, p, g;
        Console.Write("степендию=");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите расходы на проживание=");
        b = Convert.ToDouble(Console.ReadLine());
        g = 0;
        {
            while (b < a)
            {
                p = (b * 5) / 100;
                b = b + p;
                g = g + 1;
            }
            Console.WriteLine(+g);
            Console.ReadLine();
        }
    }
}
