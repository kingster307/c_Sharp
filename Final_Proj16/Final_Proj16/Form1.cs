using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;

namespace Final_Proj16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalProj16DDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.finalProj16DDataSet.Table1);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\FinalProj16D.accdb"))
            {
                //converto to int 
                string insertsql = "SELECT * FROM Table1 Where (BattingAverage >= " + textBox1.Text + " AND BattingAverage <=" + textBox2.Text + ")";


                //string insertsql = "INSERT INTO Prog3([ID], FirstName, LastName) VALUES ('" + textBox3.Text + "', '" + FNT.Text + "', '" + LnT.Text + "')";


                using (OleDbCommand command = new OleDbCommand(insertsql, connection))
                {



                    //command.Parameters.AddWithValue("@textBox3", textBox3.Text);
                    //command.Parameters.AddWithValue("@FNT", FNT.Text);
                    //command.Parameters.AddWithValue("@LnT", LnT.Text);
                    connection.Open();
                    command.ExecuteNonQuery();




                }
                connection.Close();

                table1BindingSource.DataSource = finalProj16DDataSet.Table1;
                //prog3BindingSource.DataSource = prog_3DataSet.Prog3;
                dataGridView1.DataSource = table1BindingSource;
                //dataGridView1.DataSource = prog3BindingSource;
            }





        }
    }
}
