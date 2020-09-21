using System;
using System.Windows.Forms;

namespace X___O
{
    public partial class Form1 : Form
    {
        private bool XO = false;
        private bool[] fix = new bool[9] {true, true, true, true, true, true, true, true, true};
        private int kol = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void remove()
        {
            XO = false;
            for (int a = 0; a <= 8; a++)
            {
                fix[a] = true;
            }
            kol = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "X";
        }

        private void res()
        {
                if (((button1.Text == "X") && (button2.Text == "X") && (button3.Text == "X")) ||
                    ((button4.Text == "X") && (button5.Text == "X") && (button6.Text == "X")) ||
                    ((button7.Text == "X") && (button8.Text == "X") && (button9.Text == "X")) ||
                    ((button1.Text == "X") && (button4.Text == "X") && (button7.Text == "X")) ||
                    ((button2.Text == "X") && (button5.Text == "X") && (button8.Text == "X")) ||
                    ((button3.Text == "X") && (button6.Text == "X") && (button9.Text == "X")) ||
                    ((button1.Text == "X") && (button5.Text == "X") && (button9.Text == "X")) ||
                    ((button7.Text == "X") && (button5.Text == "X") && (button3.Text == "X")))
                {
                    MessageBox.Show("Победили крестики!");
                    remove();
                }
                else if (((button1.Text == "O") && (button2.Text == "O") && (button3.Text == "O")) ||
                        ((button4.Text == "O") && (button5.Text == "O") && (button6.Text == "O")) ||
                        ((button7.Text == "O") && (button8.Text == "O") && (button9.Text == "O")) ||
                        ((button1.Text == "O") && (button4.Text == "O") && (button7.Text == "O")) ||
                        ((button2.Text == "O") && (button5.Text == "O") && (button8.Text == "O")) ||
                        ((button3.Text == "O") && (button6.Text == "O") && (button9.Text == "O")) ||
                        ((button1.Text == "O") && (button5.Text == "O") && (button9.Text == "O")) ||
                        ((button7.Text == "O") && (button5.Text == "O") && (button3.Text == "O")))
                {
                    MessageBox.Show("Победили нолики!");
                    remove();
                }
                else if (kol == 9)
                {
                    MessageBox.Show("Ничья!");
                    remove();
                }
        }

        private void change(int obj)
        {
            obj -= 1;
            if (XO)
            {
                if (fix[obj])
                {
                    switch (obj)
                    {
                        case 0:
                            button1.Text = "O";
                            break;
                        case 1:
                            button2.Text = "O";
                            break;
                        case 2:
                            button3.Text = "O";
                            break;
                        case 3:
                            button4.Text = "O";
                            break;
                        case 4:
                            button5.Text = "O";
                            break;
                        case 5:
                            button6.Text = "O";
                            break;
                        case 6:
                            button7.Text = "O";
                            break;
                        case 7:
                            button8.Text = "O";
                            break;
                        case 8:
                            button9.Text = "O";
                            break;
                    }
                    label1.Text = "X";
                    fix[obj] = false;
                    kol += 1;
                    XO = false;
                }
            }
            else
            {
                if (fix[obj])
                {
                    switch (obj)
                    {
                        case 0:
                            button1.Text = "X";
                            break;
                        case 1:
                            button2.Text = "X";
                            break;
                        case 2:
                            button3.Text = "X";
                            break;
                        case 3:
                            button4.Text = "X";
                            break;
                        case 4:
                            button5.Text = "X";
                            break;
                        case 5:
                            button6.Text = "X";
                            break;
                        case 6:
                            button7.Text = "X";
                            break;
                        case 7:
                            button8.Text = "X";
                            break;
                        case 8:
                            button9.Text = "X";
                            break;
                    }
                    label1.Text = "O";
                    fix[obj] =  false;
                    kol += 1;
                    XO = true;
                }
            }
            res();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            change(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            change(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            change(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            change(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            change(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            change(9);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            remove();
        }
    }
}