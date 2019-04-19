using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_two_Weeks_num10
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] overtime = new float[3]; float[] time = new float[3]; float[] totaltime = new float[3]; float[] pay = new float[3]; float[] hrrate = new float[3];
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("\nPlease enter Employee {0} hourly rate", x + 1);hrrate[x] = float.Parse(Console.ReadLine());
                Console.WriteLine("\nPlease enter Employee's {0} total hours worked", x + 1);totaltime[x] = float.Parse(Console.ReadLine());
                if (totaltime[x] > 40)
                {
                    time[x] = 40;
                    overtime[x] = (totaltime[x] - time[x]) + ((totaltime[x] - time[x])/2);
                    //overtime[x] = overtime[x] + (overtime[x] / 2);
                    time [x] += overtime [x];pay[x] = hrrate[x] * time[x];
                }
                else
                {
                    time[x] = totaltime[x];overtime[x] = 0;pay[x] = hrrate[0] * time[x];
                }
                Console .WriteLine("employee {0} clocked in {1} hrs, makes {2}/hr, and grossed ${3} for the week",x +1,totaltime [x],hrrate [x],Math .Round (pay [x],2));
            }
            Console.ReadLine();
        }
    }
}
