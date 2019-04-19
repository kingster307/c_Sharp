using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_Prog_3_2
{
    class Program
    {
        public static List <int> Listy =new List <int>();
        public static int NewSUM;
        public static bool again=false;
        public static bool error = false;

        public int summmm (List<int> lista)
        {
          int SUM=0;
            
            for (int y = 0; y <= 24; y++)
            {
            
                SUM += lista[y];
            }
            return SUM;
         }
        
        static void Main(string[] args)
        {
            do
            {
                Random r = new Random();
                for (int x = 1; x <= 25; x++)
                {
                    int rr = r.Next(1, 101);
                    Listy.Add(rr);
                    Listy.Sort();
                }

                Program p = new Program();
                NewSUM = p.summmm(Listy);
                float average = (NewSUM / 25);

                Console.WriteLine("Sum= " + NewSUM.ToString());
                Console.WriteLine("Average= " + average.ToString());
                do
                {
                    Console.WriteLine("Again?\nY/N");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        again = true;
                        error = false;
                    }
                    else if (Console.ReadLine().ToLower() == "n")
                    {
                        again = false;
                        error = false;
                        break;
                    }
                    else
                    {
                        Console.ReadLine();
                        error = true;
                        Console.WriteLine("Please enter in correct format\n Y/N");
                    }
                    
                } while (error == true);
            } while (again == true);
        }
    

    }
}

//error and again loops not working 
//loops delay
