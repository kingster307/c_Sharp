using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourth_two_Weeks_num5
{
    public partial class Form1 : Form
    {
        int num=1, product=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            do
            {
                if (num % 2 != 0)
                {
                    product *= num;
                    num += 1;
                }
                else
                {
                    num += 1;
                }
            } while (num < 8);
            label2.Text = Convert .ToString ( product) ;
        }
    }
}
