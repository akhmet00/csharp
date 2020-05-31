using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logregplayer
{
    public partial class mains : Form
    {
        public mains()
        {
            InitializeComponent();
        }

         void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                this.textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(axWindowsMediaPlayer1.URL);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
