using System;
class Program
{
    static void Main()
    {
        float b;
        Console.Write("введите курс рубля=");
        b = (float)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("|доллар|  рубль ");
        {
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("|{0,5} |  {1,5} ", i, i * b);
            Console.ReadLine();
        }
    }
}
