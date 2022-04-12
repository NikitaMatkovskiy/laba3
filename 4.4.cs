using System;
class Program
{
    static void Main()
    {
        int a, k;
        a = 10;
        k = 0;
        {
            while (a < 99)
            {
                a = a + 1;

                if ((2 == a % 10) || (5 == a % 10))
                    k++;
                if ((2 == a % 10) || (5 == a % 10))
                    Console.WriteLine("{0,6}", a);
            }
            Console.WriteLine("количество чисел оканчивающиеся на 2 и 5 = " + k);
            Console.ReadLine();
        }
    }
}
