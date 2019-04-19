using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_proj_3_Prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath, name;

            name = "invoice.txt";
            fpath = Path.GetFullPath(name);
        
        int[] inve = new int[3];
        double[] price = new double[3];
        string[] jobname = new string[3];
        bool[] comp = new bool[3];
        string In, Outy;
        double tryd;
       // string trys;
        int a=0,b=0,c=0,tryi;
            bool cont=false ;


        StreamWriter init = new StreamWriter(fpath);
        init.Write("123456\r\n67.99\r\nAlignment\r\n123557\r\n50.00\r\nBrake Job\r\n123558\r\n100.00\r\nRoad Hazzard");
        init.Close();
        Console.WriteLine("Press anything");
        Console.ReadKey();
        
        StreamReader red = new StreamReader(fpath);

         In = red.ReadLine();
        while (In != null)
        {
            if (a > 0 || b > 0 || c > 0)
            {
                In = red.ReadLine();
            }

            if (int.TryParse(In, out tryi))
            {
                inve[a] = tryi;
                a++;
                continue;
            }
            else if ( double .TryParse (In , out tryd))
            {
            price [b ] = tryd;
            b++;
            continue ;
            }
            else if (In != null )
            {
            jobname[c]=In;
            c++;
            continue;
            }
        }
            red .Close();
            File.Delete(fpath);
            StreamWriter w = new StreamWriter(fpath);   
            for (a=0;a<3;a++)
            {
                cont = false;
                Console.WriteLine("Invoice: {0}\r\n Job Type {1}\r\n cost {2}\r\n Completed?(y/n)", inve[a], jobname[a], price[a]);

                while (cont == false)
                {
                    Outy = Console.ReadLine();
                    if (Outy.ToLower() == "y")
                    {
                        comp[a] = true;
                        w.WriteLine("\r\nInvoice: {0}\r\n Job Type {1}\r\n cost {2}\r\n Job Completed", inve[a], jobname[a], price[a]);
                        cont = true;
                        continue;
                    }
                    else if (Outy.ToLower() == "n")
                    {
                        comp[a] = false;
                        w.WriteLine("\r\nInvoice: {0}\r\n Job Type {1}\r\n cost {2}\r\n Job not Completed", inve[a], jobname[a], price[a]);
                        cont = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Input Invalid");
                        cont = false;
                    }
                }
  
            }
         w.Close ();
         Console.Read();
        }
    }
}
//having issue with array size 
//