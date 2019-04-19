using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_Prog_3_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] salaryrange = new int [9];
            int indexing=-1,nu;
            double salary, grosssales;
            bool More_Q = false, error=false;
            //,Error=false
            string EM_Name;

            do
            {
             // EM_Name = null;
              Console.WriteLine("enter Employee Name");
              EM_Name = Console.ReadLine();
              Console.WriteLine("How much did " + EM_Name + " Gross in Sales this week?");

                //want to use trimstart here if time 
              if (double.TryParse(Console.ReadLine(), out grosssales))
              {

                  salary = ((grosssales * .09) + 200);
                  nu = (int)Math.Round(salary, 0);
                  
                  nu = nu /100;
                  if (nu > 10)
                  {
                      nu = 10;
                  }

                  switch (nu)
                  {
                      case 2:
                          {
                              indexing = 0;
                              break;
                          }
                      case 3:
                          {
                              indexing = 1;
                              break;
                          }
                      case 4:
                          {
                              indexing = 2;
                              break;
                          }
                      case 5:
                          {
                              indexing = 3;
                              break;
                          }
                      case 6:
                          {
                              indexing = 4;
                              break;
                          }
                      case 7:
                          {
                              indexing = 5;
                              break;
                          }
                      case 8:
                          {
                              indexing = 6;
                              break;
                          }
                      case 9:
                          {
                              indexing = 7;
                              break;
                          }
                      case 10:
                          {
                              indexing = 8;
                              break;
                          }
                          
                  }

                  if (indexing != -1)
                  {
                      salaryrange[indexing] += 1;
                  }

                  //foreach (int x in salaryrange)
                  //{
                  //    Console.WriteLine(x);
                  //}

                  do
                  {
                      Console.WriteLine("Enter more? Y/N");
                      string response = Console.ReadLine().ToLower();

                      if (response == "y")
                      {
                          More_Q = true;
                          break;
                      }

                      else if (response == "n")
                      {
                        //  again = false;
                          More_Q = false;
                          error = false;
                          Console.WriteLine("\n");

                          for (int yy = 0; yy <= salaryrange.GetUpperBound(0); yy++)
                          { 
                              Console.WriteLine ("There are " + salaryrange [yy] + " Employees in Salary range " + (yy+1).ToString ());
                          }

                          //foreach (int x in salaryrange)
                          //{
                          //    Console.WriteLine(x);
                          //}


                      }
                      else
                      {
                          error = true;
                          Console.WriteLine("Please Respond with y/n");
                      }
                  } while (error == true);



                  

              }
              else
              {
                  Console.WriteLine("Gross sales must be in integer format");
                  More_Q = true;
              }


            } while (More_Q == true);
            Console.Read();
            //|| Error ==true
        }
    }
}
//8. Use a one-dimensional array to solve the following problem: A company pays its salespeople on a commission basis. 
//The salespeople receive $200 per week plus 9% of their gross sales for that week. For example, a salesperson who grosses 
//$5,000 in sales in a week receives $200 plus 9% of $5,000, or a total of $650. Write an application (using an array of counters) 
//that determines how many of the salespeople earned salaries in each of the following ranges (assume that each salesperson’s salary is an integer). 
//Summarize the results in tabular format.
//a) $200-$299---------0
//b) $300-$399---------1
//c) $400-$499---------2
//d) $500-$599---------3
//e) $600-$699---------4
//f) $700-$799---------5
//g) $800-$899---------6
//h) $900-$999---------7
//i) $1000 and over---------8
/*
 * 
 * 
 * 
 * 
 * 
 */
