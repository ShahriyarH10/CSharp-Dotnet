using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int a, b;
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());

            //    Dprint(a, b);
            //}

            //static void Dprint(int a, int b)
            //{
            //    for(int i=1; i<=a; i++)
            //    {
            //        for (int j = 1; j <= b; j++) { 
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }

            //int[][] results = new int[3][];
            //results[0] = new int[] { 60, 70, 40, 35, 70 };
            //results[1] = new int[] { 60, 39, 60, 28 };

            //int a=5, b=7;

            //int a;
            //a = Convert.ToInt32(Console.ReadLine());

            //if (a == 0) {
            //    Console.WriteLine("This is zero");
            //} else if (a < 0)
            //{
            //    Console.WriteLine("This is negative");
            //}else if (a < 0)
            //{
            //    Console.WriteLine("This is postive");
            //}

            int[] b = {};
            int sum=0;
            int avg;

            for (int i =0; i < 5; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());


            }

            for(int i = 0; i<5; i++)
            {
               sum =+ b[i];

            }

            avg = sum / 5;

            Console.WriteLine(avg);





        }
       


    }
}
