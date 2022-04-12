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

                if ((3 == a % 10) || (7 == a % 10) || (3 == a / 10) || (7 == a / 10))
                    k++;
                if ((3 == a % 10) || (7 == a % 10) || (3 == a / 10) || (7 == a / 10))
                    Console.WriteLine("{0,6}", a);
            }
            Console.WriteLine("количество чисел где есть цифры 3 и 7=" + k);
            Console.ReadLine();
        }
    }
}
