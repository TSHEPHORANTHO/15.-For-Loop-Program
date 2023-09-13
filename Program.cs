using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.For_Loop_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the For Loop");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Hi, We are Looping");
                Console.WriteLine("This is i+2 " + Convert.ToInt32(i+2));
            }
            Console.WriteLine("***************This is the end of the For Loop***************");

            Console.WriteLine("***************This is the Beginning of the While Loop*******");
            Console.WriteLine("This is for the While Loop");
            int j = 0;
            while (j <= 5)

            {
                Console.WriteLine(j);

                j++;
            }
            //Print
            Console.ReadLine();
        }
    }
}
