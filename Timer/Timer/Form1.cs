using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
         
     
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
            timer2.Start();
            timer3.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            if (lblOne.Text==lblTwo.Text && lblTwo.Text == lblThree.Text)
            {
                MessageBox.Show("WINNER!! Congradulation");
            }
            else
            {
                MessageBox.Show("You Lost!! Try Again");
            }
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                int time1 = int.Parse(lblOne.Text);
            if (time1 < 9)
            {
                time1++;
            }
            else
            {
                time1 = 0;
            }
                lblOne.Text = time1.ToString();
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
                int time2 = int.Parse(lblTwo.Text);
            if (time2 < 9)
            {
                time2++;
            }
            else
            {
                time2 = 0;
            }
                lblTwo.Text = time2.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
            
                int time3 = int.Parse(lblThree.Text);
            if (time3 < 9)
            {
                time3++;
            }
            else
            {
                time3= 0;
            }
                lblThree.Text = time3.ToString();
            
           
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

            


        }
    }
}
