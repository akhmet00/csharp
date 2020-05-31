using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logregplayer
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Escanor\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            String query = "Insert into dbo.[Table] ([login],[password])  values('"+textBox1.Text+ "','" + textBox2.Text + "')";

            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            command.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("Registration Success");
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    public class Button2 : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
