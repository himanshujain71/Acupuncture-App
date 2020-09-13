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
    public partial class Po : Form
    {
        public Po()
        {
            InitializeComponent();
        }

        
        String[] list;
        int index = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.textofnext+"";

            /////////////////////////////
            try
            {
                button2.Visible = true;
                button3.Visible = true;

                String s = Form1.textofnext+"";
                String s2 = s.Split(':')[1];
                String s3 = s2.Split('.')[0];
                String[] ll = s3.Split(',');
                list = new String[ll.Length];
                for (int ii = 0; ii < ll.Length; ii++)
                { list[ii] = ("Resources/" + ll[ii].Trim() + ".jpg").Replace(" ", ""); }

                Image imgcircle = Image.FromFile(list[0]);
                pictureBox1.Image = imgcircle;
            }
            catch (Exception) { };

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Form1.textofnext + "");
            Form1  a= new Form1();
            a.Show();
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

        private void Po_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.OpenForms[0].Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = Application.StartupPath + "\\res\\" + Form1.textofnext.Substring(0, 3) + ".pdf";
                proc.Start();
            }
            catch (Exception) { MessageBox.Show("No file exists.Upload a file and try again."); }
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
                        System.IO.File.Copy(path, Application.StartupPath + "\\res\\" + Form1.textofnext.Substring(0, 3) + ".pdf", true);
                        MessageBox.Show("Successfully uploaded.");
                    }
                    catch (Exception) { MessageBox.Show("Upload Unsuccessful."); }

                }
            }
        }
    }
}
