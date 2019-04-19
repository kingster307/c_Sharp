using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourth_Two_Weeks_num2
{
    public partial class Form1 : Form
    {
       public int ProdNum, QuanQuan;
       public decimal price;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PBP1.Visible = false;
            PBP2.Visible = false;
            PBP3.Visible = false;
            P2.Visible = false;
            PP2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                ProdNum = int.Parse(textBox1.Text);
                if (textBox2.TextLength > 0)
                {
                    QuanQuan = int.Parse(textBox2.Text);

                    switch (ProdNum)
                    { 
                        case 1:
                            price = 5*QuanQuan ;
                            PBP1 .Visible =true ;
                            break;

                        case 2:
                            price =10*QuanQuan;
                            PBP2 .Visible =true ;
                            break;

                        case 3: 
                            price = 15*QuanQuan;
                            PBP3 .Visible =true ;
                            break ;

                    }


                }
                else
                {
                    //alert user that they need to input quantity 
                }
            }
            else 
            {
                //alert user that they need to input product number
            }
            P2.Visible = true ;
            PP2.Visible = true ;
            PP2.Text = "$" + price;
             ProdNum =0;
             price = 0;
       } 
    }
}
