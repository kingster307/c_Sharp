using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourth_Two_Weeks_num6
{
   
    public partial class Form1 : Form
    {
        int numb,count,x;
        int[] j=new int[3];
        string[] s3 = new string[3];
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            write();
        }

        private void write()
        {
            button1.Focus();
            numb += 1;
            Instructions .Text = "number " + numb ;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (numb <= 3)
            {
                j[numb - 1] = int.Parse(textBox1.Text);
                textBox1.Clear();
                if (numb == 3)
                {
                    Uno.Text = Convert.ToString(j[0]);


                    Dos.Text = Convert.ToString(j[1]);


                    Trees.Text = Convert.ToString(j[2]);

                    //this part will loop through adding one * each time till it reaches the specified number in the array 
                    for (int a = 0; a < 3; a++)
                    {
                        s = "";
                        count = j[a];

                        for (int g = 0; g < count; g++)
                        {
                            s = s + "*"; 
                        }
                        s3[a] = s;

                    }
                    panel1.Visible = false;
                    una.Text = s3[0];
                    dosa.Text = s3[1];
                    tresa.Text = s3[2];

                }
                write();
            }
        }
    }
}
