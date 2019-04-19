using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_Prog_3_15
{
    class Program
    {
        public static void loopvalues(bool[] SA)
        {
            for (int i = 0; i < SA.Length; i++)
            {
                SA[i] = false;
            }
        }



        static void Main(string[] args)
        {
            int FC = 0, EC = 5;
            string input,selection;
            bool error,bookagain,errorag;

            bool[] SeatingAssignment = new bool[10];
            loopvalues(SeatingAssignment);

         

            do
            {
                bookagain = false;
                do
                {
                    error = false;
                    input = null;

                    Console.WriteLine("Enter 1 for first class or 2 for economy class");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        //constant=0
                        if (FC <= 4)
                        {
                            selection = "first class";
                            SeatingAssignment[FC] = true;
                            Console.WriteLine("Congrats your in " + selection + ". Seat number " + (FC+1));
                            FC += 1;

                        }
                        else if (EC <= 9)
                        {
                            do
                            {
                            Console.WriteLine("First class is full is economy class ok? y/n");
                            input = Console.ReadLine().ToLower();


                               
                                errorag =false;

                            if (input == "y")
                            {
                                selection = "Economy Class";
                                SeatingAssignment[EC] = true;
                                Console.WriteLine("Congrats your with the poor people in " + selection + ". Seat Number " + (EC+1));
                                EC += 1;
                            }
                            else if (input == "n")
                            {

                                Console.WriteLine("Next flight leaves in 3 hours");



                            }
                            else
                            {
                                errorag = true;
                                Console.WriteLine("Incorrect Format\n");
                                
                                
                               
                            }
                            }while (errorag ==true);

                        }
                        else
                        {
                            Console.WriteLine("Sorry Plane is full, Next flight leaves in 3 hours"); 
                        }

                    }

                    else if (input == "2")
                    {
                        //constant=5
                        if (EC <= 9)
                        {
                            selection = "Economy Class";
                            SeatingAssignment[EC] = true;
                            Console.WriteLine("Congrats your with the poor people in " + selection + ". Seat Number " + (EC+1));
                            EC += 1;
                        }
                        else if (FC <= 4)
                        {
                            do
                            {
                                Console.WriteLine("economy class is full is First class ok? y/n");
                                input = Console.ReadLine().ToLower();
                                errorag = false;

                                if (input == "y")
                                {
                                    selection = "first class";
                                    SeatingAssignment[FC] = true;
                                    Console.WriteLine("Congrats your in " + selection + ". Seat number " + (FC+1));
                                    FC += 1;

                                }
                                else if (input == "n")
                                {

                                    Console.WriteLine("Next flight leaves in 3 hours");



                                }
                                else
                                {
                                    errorag = true;
                                    Console.WriteLine("Incorrect Format\n");



                                }
                            } while (errorag == true);
                        }
                        else
                        {
                            Console.WriteLine("Sorry Plane is full, Next flight leaves in 3 hours"); 
                        }
                    }
                       
                    else
                    {
                        error = true;
                        Console.WriteLine("\n unacceptable Input try again\n");
                    }


                    //error w incorrect format 
       
                } while (error == true);

                do
                {
                    errorag = false;
                    Console.WriteLine("book again? y/n");

                    input = Console.ReadLine().ToLower();


                    if (input == "y")
                    {
                        bookagain = true;

                    }
                    else if (input == "n")
                    {
                        bookagain = false;
                        Environment.Exit(0);
                        break;
                    }
                    else
                    {
                        errorag = true;
                        Console.WriteLine("Incorrect Format\n");
                    }
                } while (errorag == true);


            } while (bookagain == true);
            Console.Read();
        }
    
    }

}

//0-4 5-9


// A small airline has just purchased a computer for its new automated reservations system. 
//You have been asked to develop the new system. You’re to write an application to assign seats on 
//each flight of the airline’s only plane (capacity: 10 seats). 


//Display the following alternatives:
//Please type 1 for First Class and Please type 2 for Economy.

//If the user types 1, your applications 
//should assign a seat in the first-class section (seats 1-5). If the user types 2, your app should 
//assign a seat in the economy section (seats: 6-10).


//Use a one-dimensional array of type bool to 
//represent the seating chart of the plane. Initialize all the elements of the array to false to 
//indicate that all the seats are empty. \

//As each seat is assigned, set the corresponding elements 
//of the array to true to indicate that the seat is no longer available. Your app should 
//never assign a seat that has already been assigned. 

//When the economy section is 
//full, your app should ask the person if it’s acceptable to be placed in the first-class section 
//(and vice-versa). If yes, make the appropriate seat assignments. 

//If no, display the me ssage: Next flight leaves in 3 hours.”
