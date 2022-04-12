using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("| км   |  версты");
        {
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("|{0,5} |  {1,5} ", i, i * 0.9374);
            Console.ReadLine();
        }
    }
}
