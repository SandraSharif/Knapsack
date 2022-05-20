using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Knapsack
{
    public partial class Adding : Form
    {
        public bool to_add = false;
        public Adding(Form1 f)
        {
            InitializeComponent();
            textBox_name.MaxLength = 20;
            textBox_name.Text = "Название";
            numericUpDown_weight.Maximum = 1000;
            numericUpDown_value.Maximum = 1000;                               
        }
        private void buttonForAdd_Click(object sender, EventArgs e)
        {
            if ((textBox_name.Text != "Название"))
            {
                to_add = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Некорректные характеристики! Дайте предмету собственное индивидуальное наименование и значения веса и ценности из отрезка от 1 до 1000");
            }
        }
        public string art_name
        {
            get { return textBox_name.Text; }
        }
        public int art_weight
        {
            get { return Convert.ToInt32(numericUpDown_weight.Value); }
        }
        public int art_value
        {
            get { return Convert.ToInt32(numericUpDown_value.Value); }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar));
        }
        private void Adding_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (to_add == false)
            {
                textBox_name.Text = "NOADD";
            }
        }
    }
}
