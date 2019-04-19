using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_Prog_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //restrict input to <=30
            //use 

            List<char> LC = new List<char>();
            char[] r = new char[25];
            int co = 0;
           
            for (char c = 'A'; c < 'Z'; c++)
            {
                r[co]=c;
                co+=1;
            }

            Random rnd = new Random();
            for (int kk = 0; kk <= 29; kk++)
            {
                int RR = rnd.Next(1, 25);
                LC.Add(r[RR]);
            }
          
            var e= from ee in LC orderby ee ascending select ee;
            var l = from ll in LC orderby ll descending select ll;
            var w = (from ww in LC orderby ww ascending select ww).Distinct();
            
            
            
            
            foreach (char ccc in LC)
            {
                Console.Write(ccc + " ");
            }

            Console.WriteLine("\n");

            foreach (char ttt in e)
            {
                Console.Write(ttt + " ");
            }

            Console.WriteLine("\n");

            foreach (char wer in l)
            {
                Console.Write(wer + " ");
            }

            Console.WriteLine("\n");

            foreach (char we in w)
            {
                Console.Write(we + " ");
            }

            Console.ReadLine();

        }
    }
}

// Write a console application that inserts 30 random letters into a List . 
//Perform the following queries on the List and display your results: [Hint: 
//Strings can be indexed like arrays to access a character at a specific index.] 
//a) Use LINQ to sort the List in ascending order. b) Use LINQ to sort the List in 
//descending order. c) Display the List in ascending order with duplicates removed. 