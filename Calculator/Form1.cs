using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            onbtnClick("3");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            onbtnClick("1");
        }

        private void onbtnClick(String input)
        {
            int pointer = result.SelectionStart;
            result.Text = result.Text.Insert(pointer, input);
            result.SelectionStart = pointer + 1;
            result.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            onbtnClick("2");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            onbtnClick("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            onbtnClick("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            onbtnClick("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            onbtnClick("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            onbtnClick("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            onbtnClick("9");
        }
    }
}
