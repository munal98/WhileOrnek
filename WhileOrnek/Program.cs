using System;

namespace WhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int toplam = 0;

            while (a<=997)
            {
                toplam += a * b - c * d;
                a += 4;
                b += 4;
                c += 4;
                d += 4;
            }

            ///(1*2-3*4) + (5*6-7*8) +.....+(997*998-999*1000)
            toplam = 0;
            for(int a1=1; a1<=997; a1 +=4)
            {
                toplam += a1 * (a1 + 1) - (a1 + 2) * (a1 + 3);
            }

            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine();
            
        }
    }
}
