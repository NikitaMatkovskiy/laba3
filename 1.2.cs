using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("| фунты|  кг    ");
        {
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("|{0,5} |  {1,5} ", i, i * 0.453);
            Console.ReadLine();
        }
    }
}
