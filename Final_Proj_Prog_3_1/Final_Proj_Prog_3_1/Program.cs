using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_Prog_3_1
{
    class Program
    {
        public static bool noError = true;
        public static bool tryagain = false;
        
        public static void PrimeNumber(int number)
        {
            if (number >= 4 && number >0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
            else if (number > 0)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                noError = false;
                Console.WriteLine("Number nust be > 0");
            }
            if (noError == true)
            {
                again();
            }
        }

        public static void again()
        {
           
            bool nogood=false ;

            do 
            {
           Console.WriteLine("Try again?\nY/N");
           string s = Console.ReadLine();
           if (s.ToLower() == "y")
           {
                nogood = false;
               tryagain = true;
           }
           else if (s.ToLower() == "n")
           {
                nogood = false;
               tryagain = false;
           }
           else
           {
               nogood = true;
               Console.WriteLine("Please Input y/n for your response");
           }
            }while(nogood==true);
        }

        static void Main(string[] args)
        {
            do
            {
                do
                {
                    int inputI;
                    string InputS;

                    Console.WriteLine("Please Enter A Number\n");
                    InputS = Console.ReadLine();
                    if (int.TryParse(InputS, out inputI))
                    {
                        noError = true;
                        PrimeNumber(inputI);
                    }
                    else
                    {
                        noError = false;

                    }

                } while (noError == false);

            } while (tryagain == true);

        }
    }
}
//n not working 