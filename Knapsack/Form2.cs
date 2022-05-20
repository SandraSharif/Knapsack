using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Knapsack
{
    public partial class Form2 : Form
    {
        public bool repeat_add = false;
        public Form2(Form1 f)
        {
            InitializeComponent();
            numericUpDown_count.Minimum = 2;
            numericUpDown_count.Maximum = 1000;
        }
        public string art_name_repeat
        {
            get { return textBox1.Text; }
        }
        public int art_count
        {
            get { return Convert.ToInt32(numericUpDown_count.Value); }
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            repeat_add = true;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            repeat_add = false;
            this.Close();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (repeat_add == false)
            {
                textBox1.Text = "Forgot";
            }
            if (repeat_add == true)
            {
                textBox1.Text = "Increase";
            }
        }
    }
    }
