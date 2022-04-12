using System;
class Program
{
    static void Main()
    {
        int a,k;
        a = 100;
        {
            while (a < 1000)
            {
                a = a + 1;
                k = a % 100;                
                if (a==7*k)
                    Console.WriteLine("{0,6}", a) ;
            }

            Console.ReadLine();
        }
    }
}