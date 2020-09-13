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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string[] listf;
        int cycler = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            int i = 0;
            //1
            for (i = 1; i <= 28; i++)
                str1 = str1 + "GV" + i + ",";
            //2
            for (i = 1; i <= 44; i++)
                str1 = str1 + "GB" + i + ",";
            //3
            for (i = 1; i <= 9; i++)
                str1 = str1 + "HT" + i + ",";
            for (i = 1; i <=27; i++)
                str1 = str1 + "KI" + i + ",";
            for (i = 1; i <= 20; i++)
                str1 = str1 + "LI" + i + ",";
            for (i = 1; i <= 14; i++)
                str1 = str1 + "LIV" + i + ",";
            for (i = 1; i <= 11; i++)
                str1 = str1 + "LU" + i + ",";
            for (i = 1; i <= 9; i++)
                str1 = str1 + "PC" + i + ",";
            for (i = 1; i <= 24; i++)
                str1 = str1 + "CV" + i + ",";

            for (i = 1; i <=19; i++)
                str1 = str1 + "SI" + i + ",";
            for (i = 1; i <= 21; i++)
                str1 = str1 + "SP" + i + ",";
            for (i = 1; i <= 45; i++)
                str1 = str1 + "ST" + i + ",";
            for (i = 1; i <= 23; i++)
                str1 = str1 + "TW" + i + ",";

            for (i = 1; i <= 66; i++)
                str1 = str1 + "BL" + i + ",";
            str1+="BL" +67 + ",";
         string[]  lis = str1.Split(',');
             
            string substr1 = "";
            substr1 = textBox1.Text.ToUpper();
            string dispstr = "";

            for (i = 0; i < lis.Length; i++)
            { if (lis[i].Contains(substr1))
                    dispstr += lis[i]+" ";
            }
            label1.Text = dispstr + "";
            //pictureBox1.
            try
            {
                listf = dispstr.Split(' ');
                Image imgcircle = Image.FromFile(("Resources/" + listf[0].Trim() + ".jpg"));
                pictureBox1.Image = imgcircle;
                cycler = 0;
            }
            catch (Exception) { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //button1.PerformClick();
            textBox1_TextChanged(sender, e);
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {try { 
            cycler--;
                
            if (cycler < 0)
                cycler = listf.Length-2;
                Image imgcircle = Image.FromFile(("Resources/" + listf[cycler].Trim() + ".jpg"));
            pictureBox1.Image = imgcircle;
        }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cycler++;
                if (cycler > listf.Length-2)
                    cycler = 0;
                Image imgcircle = Image.FromFile(("Resources/" + listf[cycler].Trim() + ".jpg"));
                pictureBox1.Image = imgcircle;
            }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Close();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
            //Application.OpenForms[0].Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str1 = "";
            int i = 0;
            //1
            for (i = 1; i <= 28; i++)
                str1 = str1 + "GV" + i + ",";
            //2
            for (i = 1; i <= 44; i++)
                str1 = str1 + "GB" + i + ",";
            //3
            for (i = 1; i <= 9; i++)
                str1 = str1 + "HT" + i + ",";
            for (i = 1; i <= 27; i++)
                str1 = str1 + "KI" + i + ",";
            for (i = 1; i <= 20; i++)
                str1 = str1 + "LI" + i + ",";
            for (i = 1; i <= 14; i++)
                str1 = str1 + "LIV" + i + ",";
            for (i = 1; i <= 11; i++)
                str1 = str1 + "LU" + i + ",";
            for (i = 1; i <= 9; i++)
                str1 = str1 + "PC" + i + ",";
            for (i = 1; i <= 24; i++)
                str1 = str1 + "CV" + i + ",";

            for (i = 1; i <= 19; i++)
                str1 = str1 + "SI" + i + ",";
            for (i = 1; i <= 21; i++)
                str1 = str1 + "SP" + i + ",";
            for (i = 1; i <= 45; i++)
                str1 = str1 + "ST" + i + ",";
            for (i = 1; i <= 23; i++)
                str1 = str1 + "TW" + i + ",";

            for (i = 1; i <= 66; i++)
                str1 = str1 + "BL" + i + ",";
            str1 += "BL" + 67 + ",";
            string[] lis = str1.Split(',');

            string substr1 = "";
            substr1 = textBox1.Text.ToUpper();
            string dispstr = "";

            for (i = 0; i < lis.Length; i++)
            {
                if (lis[i].Contains(substr1))
                    dispstr += lis[i] + " ";
            }
            label1.Text = dispstr + "";
            //pictureBox1.
            try
            {
                listf = dispstr.Split(' ');
                Image imgcircle = Image.FromFile(("Resources/" + listf[0].Trim() + ".jpg"));
              //  if (imgcircle == null)
                //    pictureBox1.Image = System.Drawing.SystemIcons.Error.ToBitmap();
                 pictureBox1.Image = imgcircle;
                //pictureBox1.Image = System.Drawing.SystemIcons.Error.ToBitmap();

                cycler = 0;
            }
            catch (Exception) { }
        }
    }
}
