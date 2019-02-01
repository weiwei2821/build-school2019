using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {
        int[] i = new int[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.DataSource = null;
            button1.Enabled = true;
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random result = new Random();
            answer.Clear();
            for (int j = 0; j< 4; j++)
            {
                i[j] = result.Next(0, 10);
                for (int k = 0; k< j; k++)
                {
                    if (i[j] == i[k])
                    {
                        j--;
                    }
                }
            }
            button1.Enabled = false;
            button2.Enabled = true;
        }
        List<string> answer = new List<string>();

        private void changedata()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = answer;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            for(int j = 0; j < 4; j++)
            {
                label1.Text = label1.Text + i[j].ToString();
            }
            label1.Visible = true;
        }
        int A, B;
        private void button3_Click(object sender, EventArgs e)
        {
            A = 0; B = 0;
            char[] result = new char[4];
            result = textBox1.Text.ToCharArray();
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    
                    if (i[a].ToString() == result[b].ToString())
                    {
                        if (a == b)
                        {
                            A++;
                        }
                        else if (a != b) B++;
                    }
                }
            }
            answer.Add("玩家猜"+textBox1.Text+":則為"+ A+"A"+B+"B");

            changedata();
        }
    }
}
