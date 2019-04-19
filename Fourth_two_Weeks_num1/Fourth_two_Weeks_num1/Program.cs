using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fourth_two_Weeks_num1
{
    class Program
    {
        static void Main(string[] args)
        {
           int smallest=0,x=0,c=0;
            Console.WriteLine("How many numbers would you like to input?");
           int number = int.Parse(Console.ReadLine());
           int[] AllNumbers = new int[number];
            while (x < number)
            {
                Console.WriteLine("{0}) Please Enter a number", number-number +(x+1));
                AllNumbers[x] = int.Parse(Console.ReadLine());
                x++;
            }
            smallest = AllNumbers[0];
            for (int y = 1; y < number; y++)
            {
                if (smallest > AllNumbers[y])
                {
                    smallest = AllNumbers[y];
                }
            }
           Console.WriteLine("Smallest number: {0}", smallest);
           Console.Read();
        }
    }
}
