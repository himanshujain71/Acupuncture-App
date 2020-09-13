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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       int indexe=1;
        String[] list;
        int index = 0;
        private void Form5_Load(object sender, EventArgs e)
        {
            int end = 0 ;
            string str = "";
            int number = Form6.indexyz;
            switch (number)
            {
                case 1: end = 28;str = "GV";break;
                case 2: end = 44; str = "GB"; break;
                case 3: end = 9; str = "HT"; break;
                case 4: end = 27; str = "KI"; break;
                case 5: end = 20; str = "LI"; break;
                case 6: end = 14; str = "LIV"; break;
                case 7: end = 11; str = "LU"; break;
                case 8: end = 9; str = "PC"; break;
                case 9: end = 24; str = "CV"; break;
                case 10: end = 19; str = "SI"; break;
                case 11: end = 21; str = "SP"; break;
                case 12: end = 45; str = "ST"; break;
                case 13: end = 23; str = "TW"; break;
                case 14: end = 67; str = "BL"; break;
                    
            }
            string labstr = "";
            for (int i = 1; i < end; i++)
            { labstr = labstr + str+i+","; }
            labstr +=str+end+".";
           // MessageBox.Show("" +labstr);
            label1.Text = labstr;
            try
            {
                String s3 = labstr.Split('.')[0];

                String[] ll = s3.Split(',');
                list = new String[ll.Length];
                for (int ii = 0; ii < ll.Length; ii++)
                { list[ii] = ("Resources/" + ll[ii].Trim() + ".jpg").Replace(" ", ""); }

                Image imgcircle = Image.FromFile(list[0]);
                pictureBox1.Image = imgcircle;

                //////////////////////////////////////////////////
               // String imgfl = ("Resources/" + str + indexe + ".jpg");

                //Image imgcircle = Image.FromFile(imgfl);
                //pictureBox1.Image = imgcircle;
            }
            catch (Exception) { };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                index--;

                if (index < 0)
                    index = list.Length - 1;
                Image imgcircle = Image.FromFile(list[index]);
                pictureBox1.Image = imgcircle;
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                index++;
                if (index > list.Length - 1)
                    index = 0;
                Image imgcircle = Image.FromFile(list[index]);
                pictureBox1.Image = imgcircle;
            }
            catch (Exception) { }
        }
        public int passfunc()
        {
            while (true)
            {
                String myValue = Microsoft.VisualBasic.Interaction.InputBox("Please enter the password:", "Password", " ");
                if (myValue.CompareTo("") == 0)
                {
                    return 0;
                }
                else if (myValue.CompareTo("d0ct0r") == 0)
                {
                    MessageBox.Show("Access Granted.");
                    return 1;
                }
                else if (myValue.CompareTo(" ") == 0)
                {
                    MessageBox.Show("Please enter a password!");
                }
                else
                    MessageBox.Show("Wrong Password!Please try again.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = Application.StartupPath + "\\res\\" + Form6.indexyz + ".pdf";
                proc.Start();
            }
            catch (Exception) { MessageBox.Show("No file exists.Upload a file and try again."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (passfunc() == 1)
            {
                string path;
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    //  MessageBox.Show(path + "");
                    try
                    {
                        System.IO.File.Copy(path, Application.StartupPath + "\\res\\" + Form6.indexyz + ".pdf", true);
                        MessageBox.Show("Successfully uploaded.");
                    }
                    catch (Exception) { MessageBox.Show("Upload Unsuccessful."); }
                }
            }
        }
    }
}
