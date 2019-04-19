using System;
using System.Collections;

namespace Final_Proj_prog_3_20
{
    class MainClass
    {

        public static [,] l;
        //maybe use dictionary....



        public bool Inarray(string mina)
        {
            bool inside=false;


            foreach (string c in l)
            {


            }

            //check if letter is in array 
            //if it is then add one to count


            return inside;
        }

        public void Letterfound()//maybe array 
        {

            //if it is in array check which row 
                //always on second column
            //set it equal to itself +=1

           
        }

        public void Letternotfound()
        {

            //if it isnt then resize array +1 row 

        }



        public static void Main(string[] args)
        {
           
            Console.WriteLine("Write Something");
            string p = Console.ReadLine();
            int i = p.Length;
          
            l = new Array[i, 1];

            for (int o = 0; o <= i;o++)
            {
                string str = p.Substring(o,1);
                if (str != " ")
                {
                 

                    
                }

            }

        }




    }
}
//2 columns and dynamically resize rows


//Write an application that counts the number of 
//occurrences of each letter in a string. For example: 
//“HELLO THERE” contains two Hs, three Es, two Ls, one O, 
//one T and one R. Display the results.

//double array (0)=letter (1)=number