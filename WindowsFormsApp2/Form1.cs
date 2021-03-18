using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class калькулятор : Form
    {
        public калькулятор()
        {
            InitializeComponent();
            
            
        }

        private void калькулятор_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(21, 30, 51);
            this.BackColor = Color.FromArgb(46, 52, 72);
            Close.ForeColor = Color.FromArgb(26, 26, 26);
            label1.ForeColor = Color.FromArgb(154, 164, 176);
            button1.BackColor = Color.FromArgb(21, 30, 51);
            button1.ForeColor = Color.FromArgb(40, 115, 198);
            button2.BackColor = Color.FromArgb(21, 30, 51);
            button2.ForeColor = Color.FromArgb(40, 115, 198);
            panel2.BackColor = Color.FromArgb(46, 52, 72);
            textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox1.Text = "R=";
            textBox1.ForeColor = Color.Gray;
            panel3.Visible = false;
            textBox2.ForeColor = Color.Black;
        }



        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void textBox1_load(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "R=";
                textBox1.ForeColor = Color.Gray;
            } 
        }

        private void textBox1_Aktiv(object sender, EventArgs e)
        {
            if (textBox1.Text == "R=")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Ответ:" + Convert.ToString(2*3.14*Convert.ToDouble( textBox1.Text));
            textBox2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = "Ответ:" + Convert.ToString(2*3.14*Convert.ToDouble( textBox1.Text));
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
