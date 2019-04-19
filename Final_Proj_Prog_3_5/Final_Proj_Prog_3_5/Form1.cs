using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj_Prog_3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.booksDataSet.Books);




        }
    }
}

// Create an application that uses the Books database and 
//displays the results of the following queries: 

//a) Get a list of all the titles and the authors who wrote them. Sort the results by title. 

//b) For each title sort the authors alphabetically by last name, then first name. 

//c) Get a list of all the authors grouped by title, sorted by title; for a
//given title sort the author names alphabetically by last name and then first name.
