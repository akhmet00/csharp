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
namespace Logregplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Escanor\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
         
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.[Table]  Where login = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", sqlcon);
            DataTable dtbl= new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows[0][0].ToString() == "1") 
            {
              
                this.Hide();
                mains mainobj = new mains();
                mainobj.Show();
            }
            else
            {
                MessageBox.Show("Check login or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
