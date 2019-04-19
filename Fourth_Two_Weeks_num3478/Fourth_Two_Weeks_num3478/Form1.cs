using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourth_Two_Weeks_num3478
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  num 3 
              /*  (what does this code do?) 
               what does the following code segment do?
               
               for ( int i=1;i<=5;++1)
               {
               * for (j=1;j<=3;++j)
               * {
               *    for (int k=1; k<=4; ++k)
               *    {
               *    console.write('*');
               *    }
               *  console.write();
               *  }
               console.writeline();
               }
               
                Answer:
               * 
               * the code will write a serious of 3 
               * sets of 4 ateriks on the same line 
               * then do the same on three different 
               * lines
               
               */

            //num4
                /*
                  describe the four basic elements of counter-controlled iteration
                  1) controlled variable (loop counter)
                 * 2) initial value of the control variable 
                 * 3) the increment/decrement by which control variable is modified through the loop
                 * 4) the loop continuation condition that determines if looping should continue
                  
                 
                 */
            
            //num7
            /*
             find and correct the errors in each of the following segments of code
             
             a) for (i=100, i>=1,++1)
             * {
                   console.writeline(i);
             * }
             * 
             * 
             * answer: this is an eternal loop needs a defined ending point or it prints 100 to infinity
             * for (int i=100;i>=1;++1)
             * {
             *      console.writeline(i);
             * }
              
             * 
             * 
             * 
             * 
              b) the following code should display wheather integer value is odd or even 
             * 
             * switch(value%2)
             * {
             * 
             * case0:
             * console.writeline("Even integer");
             * 
             * case 1: 
             * console.writeline("Odd integer")
             * 
             * 
             * }
             * 
             * 
             * Answer:
             * 
             * switch(value%2)
             * {
             * case 0: 
             * console.writeline("Even integer");
             * break;
             * 
             * case 1:
             * console.writeline("Odd integer");
             * break;
             * 
             * }
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * c) The following code should output the odd integers from 19 to 1:
             * 
             * for(int = 19; i>=1; i+=2)
             * {
             * 
             * console.writeline(i)
             * 
             * }
             * 
             * 
             * Answer: 
             * 
             *  for(int i = 19; i>=1; i-=2)
             * {
             * 
             * console.writeline(i);
             * 
             * }
             * console.read();
             * 
             * 
             * 
             * 
             * 
             * d) The following code should output the even integers from 2 to 100
             * 
             * counter =2; 
             * 
             * do 
             * {
             * 
             * console.writeline(counter);
             * counter+=2;
             * 
             * }while(counter<100);
              
             * 
             * 
             * 
             * Answer:
             * 
             * int counter =2; 
             * 
             * do 
             * {
             * console.writeline(counter);
             * counter+=2;
             * 
             * }while(counter<=100);
              
             * 
             * 
     
             */
            //num8
            /*
             * (Integer Division) Explain what happens when a c# app attempts to
             * divide one integer by another What happens to the fractional part of
             * the calculation? How can you avoid that outcome
             * 
             * when a c# app divides one integer by another the answer will be an integer unless the answer is put into another data type other than
             * integer. The integer data type simply cuts off the decimal point and only displays the whole integer. So to avoid this change the data
             * type to float, decimal, or another data type that supports decimals
             * 
             * 
             * 
             * 
             * 
             * 
             * 
           */ 




        }
    }
}
