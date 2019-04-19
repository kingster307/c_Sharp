using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj_Prog_3_13
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

//Create a program that stores student grades in a text file. The file should contain
//the name, ID number, class taken and grade of every student. Allow the user to load a grade
//    file and display its contents in a read-only TextBox. The entries should be displayed in
//    the following format: LastName, FirstName: ID# Class Grade Some example data is listed below:
//Jones, Bob: 1 “Introduction to Computer Science” “A – ”
//Johnson, Sarah: 2 “Data Structures” “B+”
//Smith, Sam: 3 “Introduction to Computer Science” “C”