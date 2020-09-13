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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

       
private void button3_Click(object sender, EventArgs e)
        {
 
            Application.Exit();
        }
        public static string textofnext = "";
   
        public void callfunf()
        {
            Po aaa= new Po();
            aaa.Show();
            this.Hide();

           
        }
        private void button4_Click(object sender, EventArgs e)
        {
             textofnext= "SOURCE POINT:HT7,SI4,PC7,TW4,SP3,ST42,LU9,LI4,KI3,UB64,LV3,GB40.";callfunf();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             textofnext= "GENERAL SEDATON POINT:HT7,PC6,TW5,LI4,UB62,GB20,GB34,GV20.";callfunf();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
             textofnext= "HORARY POINT:HT8,SI5,PC8,TW6,SP3,ST36,LU8,LI1,KI10,UB66,LV1,GB41.";callfunf();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             textofnext= "SEDATION POINT-SON:HT7,SI8,PC7,TW10,SP5,ST45,LU5,LI2,KI1,UB65,LV2,GB38.";callfunf();
        }

        private void button8_Click(object sender, EventArgs e)
        {
             textofnext= "TONIFICATION POINT-MOTHER:HT9,SI3,PC9,TW3,SP2,ST41,LU9,LI11,KI7,UB67,LV8,GB43.";callfunf();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             textofnext= "GENERAL TONIFICATION POINT:PC4,SP6,ST36,LI11,LV8,CV6.";callfunf();
        }

        private void button10_Click(object sender, EventArgs e)
        {
             textofnext= "LUO-CONNECTING:HT5,SI7,PC6,TW5,SP4,SP21,ST40,LU7,LI6,KI4,UB58,LV5,GB37,GV1,CV15.";callfunf();
        }

        private void button11_Click(object sender, EventArgs e)
        {
             textofnext= "Xi-CLEFT:HT6,SI6,PC4,TW7,SP8,ST34,LU6,LI7,KI5,UB63,LV6,GB36.";callfunf();


        }

        private void button12_Click(object sender, EventArgs e)
        {
             textofnext= "JING WELL POINT:HT9,SI1,PC9,TW1,SP1,ST45,LU11,LI1,KI1,UB67,LV1,GB44.";callfunf();
        }

        private void button13_Click(object sender, EventArgs e)
        {
             textofnext= "MU-ALARM POINT:CV14,CV4,CV17,CV5,LV13,CV12,LU1,ST25,GB25,CV3,LV14,GB24.";callfunf();
        }

        private void button14_Click(object sender, EventArgs e)
        {
             textofnext= "BACK SHU POINT:UB15,UB27,UB14,UB22,UB20,UB21,UB13,UB25,UB23,UB28,UB18,UB19.";callfunf();
        }

        private void button15_Click(object sender, EventArgs e)
        {
             textofnext= "EXCRETION-DISCHARGE POINT	:PC3,TW6,SP9,SP5,ST41,LU5,LI18,KI14,UB67,GB14,CV23,CV24.";callfunf();
        }

        private void button16_Click(object sender, EventArgs e)
        {
             textofnext= "EXCRETION-CONTROL POINT:HT8,PC8,SP5,SP3,LU10,LI20,LI1,K7,K14,UB57,UB66,LV4,GV25,GV26.";callfunf();
        }

        private void button17_Click(object sender, EventArgs e)
        {
             textofnext= "VERMA POINT:HT3,PC3,SP9,LU5,LI18,UB66.";callfunf();
        }

        private void button18_Click(object sender, EventArgs e)
        {
             textofnext= "IMMUNITION POINT:PC4,PC6,TW23,SP6,SP9,SP10,ST36,LI11,LIV8,GV14";callfunf();
        }

        private void button19_Click(object sender, EventArgs e)
        {
             textofnext= "DANGEROUS POINTS:HT1,PC1,SP4,ST1,ST21,ST25,LU1,LU9,LI18,UB1,UB10,UB67,LV3,GV15,GV16,CV8.";callfunf();
        }

        private void button20_Click(object sender, EventArgs e)
        {
             textofnext= "ANALGESIC EFFECT POINT:ST44,LI4.";callfunf();
        }

        private void button22_Click(object sender, EventArgs e)
        {
             textofnext= "SEDATIVE POINTS:PC6,GV20.";callfunf();
        }

        private void button23_Click(object sender, EventArgs e)
        {
             textofnext= "HOMEOSTATIC EFFECT POINTS(REGULATORY EFFECT):SP6,ST36,LI11.";callfunf();
        }

        private void button24_Click(object sender, EventArgs e)
        {
             textofnext= "PSYCHOLOGICAL EFFECT POINTS:HT7,PC6,GV20.";callfunf();
        }

        private void button25_Click(object sender, EventArgs e)
        {
             textofnext= "MOTOR RECOVERY POINTS:ST32,LI10.";callfunf();
        }

        private void button26_Click(object sender, EventArgs e)
        {
             textofnext= "HE-SHE POINTS:HT3,SI8,PC3,TW10,SP9,ST36,LI11,LU5,KI10,UB40,LIV8,GB34.";callfunf();
        }

        private void button27_Click(object sender, EventArgs e)
        {
             textofnext= "INFLUENTIAL POINTS:CV17,UB11,UB17,CV12,LV13,LU9,GB34,GB39";callfunf();
        }

        private void button29_Click(object sender, EventArgs e)
        {
             textofnext= "DISTAL POINTS:LI4,LU7,P6,ST36,UB40,SP6";callfunf();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button21_Click(object sender, EventArgs e)
        {
           //Form8 frm = new Form8();
            //frm.Show();
            //this.Hide();

        }
    }
}
