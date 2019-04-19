using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj_Prog_3_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//17. Modify the above to allow the user to locate player with batting averages in a specific range.
//Add a minimumTextBox for the minimum batting average (0 by default) and a maximumTextBox for the 
//maximum batting average (1 by default). Use a Label to identify each TextBox. Add a Button for executing
//a query that selects rows from the Players table in which the BattingAverage column is greater than or 
//equal to the specified minimum value and less than or equal to the specified maximum value.