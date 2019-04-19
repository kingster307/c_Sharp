using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Proj_Prog_3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                make array 
             * loop through 10 times 
             * conditional statement testing if 
             * the number is even
             *      if it is then use LINQ
             *      if not continue
             */

            int[] evens = new int[10];


            for (int x = 0; x <= evens.GetUpperBound(0); x++)
            {

                evens[x] = x + 1;
            }

            var evennum = from n in evens where (n % 2 == 0) select n;
          
            foreach (var x in evennum )
            {
            Console.WriteLine (x);
            }
         
            Console.ReadLine();
        }
    }
}
//Use LINQ to fill an array with the even integers from 2 to 10.