using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_two_Weeks_num9
{
    class Program
    {
        //static void problem()
        //{ 
        
        //}
     
        //math not right 
        static void Main(string[] args)
        {
            float totalaveragempg=0.0F, tripmpg=0.0F,milestraveled=0.0F, gallonsused = 0.0F,avergtot=0.0F;
            int tanknum=0;

           //Console .WriteLine("Please Enter miles traveled");
           // milestraveled = float .Parse (Console.ReadLine ());
           // Console.WriteLine ("Please enter gallons used");
           // gallonsused = float .Parse (Console.ReadLine ());
           // tanknum +=1;
           // tripmpg = milestraveled / gallonsused;
           // totalaveragempg = ((totalaveragempg + tripmpg) / tanknum);
           // Console.WriteLine("trip MPG " + Math.Round(tripmpg, 2) + "\n" + "Total average MPG " + Math.Round(totalaveragempg, 2));

            while (milestraveled != -1)
            {
                Console.WriteLine("\nPlease Enter miles traveled to continue or enter -1 to exit");
                milestraveled = float.Parse(Console.ReadLine());
                if (milestraveled != -1)
                {
                    Console.WriteLine("Please enter gallons used");
                    gallonsused = float.Parse(Console.ReadLine());
                    tanknum += 1;
                    tripmpg = milestraveled / gallonsused;
                    avergtot += tripmpg;
                    totalaveragempg = avergtot / tanknum;
                    Console.WriteLine("trip MPG " + Math.Round(tripmpg, 2) + "\n" + "Total average MPG " + Math.Round(totalaveragempg , 2));
                    continue;
                }
                Console.Read();
            }

            
        }
    }
}

