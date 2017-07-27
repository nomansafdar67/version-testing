using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_tack_toe
{
    public partial class Form1 : Form
    {
        bool turn = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void check()
        {
            if(btn1.Text == "✔" && btn2.Text == "✔" && btn3.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn4.Text == "✔" && btn5.Text == "✔" && btn6.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn7.Text == "✔" && btn8.Text == "✔" && btn9.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn1.Text == "✔" && btn4.Text == "✔" && btn7.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn2.Text == "✔" && btn5.Text == "✔" && btn8.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn3.Text == "✔" && btn6.Text == "✔" && btn9.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn1.Text == "✔" && btn5.Text == "✔" && btn9.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn3.Text == "✔" && btn5.Text == "✔" && btn7.Text == "✔")
            {
                textBox1.Text = "Player One wins";
            }
            else if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            else if(btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false )
            {
                textBox1.Text = "Match is Draw";
            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                textBox1.Text = "Player Two wins";
            }
            
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(turn)
            {
                btn.Text = "X";
                turn = false;
            }
            else
            {
                btn.Text = "✔";
                turn = true;
            }
            btn.Enabled = false;
            check();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
