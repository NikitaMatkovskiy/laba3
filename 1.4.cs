using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("| дюйм |  см    ");
        {
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("|{0,5} |  {1,5} ", i, i * 2.54);
            Console.ReadLine();
        }
    }
}
