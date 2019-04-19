using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_Prog_3_11
{
    class Program
    {
        static void Main(string[] args)
        {

            //create list 
            //have user enter first names 
            //check if name is already in list 
                //if it is then do not add and inform user of duplicate 
            //else
                //store name in list
            //once user is done ask if they want to search for a name
            //if name is in list then tell them 
            //else tell them no name exists 
            //sentenal loop to determine when theyre done searching 
            //exit


            bool errorI = false,moreNames=false,againerror=false;
            string input,again;
            List <string > FN = new List<string>();

            do 
            {
                moreNames = false;
                do
                {
                    errorI = false;
                    again = null; input = null;
                     Console.WriteLine("Please Enter a First Name");
                    input = Console.ReadLine().ToLower();

                    if (input.Contains(" "))
                    {
                        errorI = true;
                        Console.WriteLine("Only First Names Are Excepted");
                    }
                    else if (FN.Contains (input))
                    {
                        errorI = true;
                        Console.WriteLine("Duplicates are not permitted");
                    }
                    else 
                    {
                    FN.Add (input);
                    do
                    {
                        againerror = false;
                        Console.WriteLine("Enter another name? y/n");
                        again = Console.ReadLine().ToLower();

                        if (again == "y")
                        {
                            moreNames = true;
                        }
                        else if (again == "n")
                        {
                            moreNames = false;

                        }
                        else
                        {
                            Console.WriteLine("Please Enter a Valid Response");
                            againerror = true;
                        }
                    } while (againerror == true);
                    }

                } while (errorI == true);
            }while (moreNames ==true );

            do
            {
                input = null; againerror = true; again = null;
                Console.WriteLine("\nWould You like to search for a name? y/n");
                input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    Console.WriteLine("Please enter a name");
                    again = Console.ReadLine().ToLower();

                    if (FN.Contains(again))
                    {
                        Console.WriteLine("\n{0} is contained in the list", again);
                    }
                    else
                    {
                        Console.WriteLine("\n{0} isn't contained in the list", again);
                    }
                }
                else if (input == "n")
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Response");
                    againerror = true;
                }
            } while (againerror == true);
            
            return;
        }
    }
}
