using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new project_final.Form1();
            a.Show();
            this.Close();
        }
        public static int indexyz = 0;
        public void abc(int a)
        {
            Form5 forma = new Form5();
            forma.Show();
            this.Hide();
            //Process of opening pdf starts
            /* try
             {
                 System.Diagnostics.Process proc = new System.Diagnostics.Process();
                 proc.EnableRaisingEvents = false;
                 proc.StartInfo.FileName = Application.StartupPath + "\\res\\" + a + ".pdf";
                 proc.Start();
             }
             catch (Exception) { }
         */
        }
        private void button8_Click(object sender, EventArgs e)
        {
            indexyz = 1;
            abc(indexyz);        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexyz = 2;
            abc(indexyz);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indexyz = 3;
            abc(indexyz);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indexyz = 4;
            abc(indexyz);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            indexyz = 5;
            abc(indexyz);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            indexyz = 6;
            abc(indexyz);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            indexyz = 7;
            abc(indexyz);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            indexyz = 8;
            abc(indexyz);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            indexyz = 9;
            abc(indexyz);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            indexyz = 10;
            abc(indexyz);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            indexyz = 11;
            abc(indexyz);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            indexyz = 12;
            abc(indexyz);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            indexyz = 13;
            abc(indexyz);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            indexyz = 14;
            abc(indexyz);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form7 frms = new Form7();
            frms.Show();
            this.Hide();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.OpenForms[0].Close();
        }
    }
}
