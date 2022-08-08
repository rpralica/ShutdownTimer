using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    
    public partial class Form1 : Form
    {
        int hours, mins, secs;

        [DllImport("user32")]
        public static extern void Loggoff();
        public Form1()
        {
           
            InitializeComponent();
            
           

        }

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 61; i++)
            {
                cboSekund.Items.Add(i.ToString());
                cboMinut.Items.Add(i.ToString());
            }
            for (int j = 0; j < 13; j++)
            {
            cboSat.Items.Add(j.ToString());
            }

            if (cboSat.Text == "0" && cboMinut.Text == "0" && cboSekund.Text == "0")
            {
                button1.Enabled = false;
            }
            else if(cboSat.Text == "" || cboMinut.Text != "" || cboSekund.Text != "")
            {
                button1.Enabled = true;
            }
           

        }
private void button1_Click(object sender, EventArgs e)
        {
           
            hours = int.Parse(cboSat.Text);
            mins = int.Parse(cboMinut.Text);
            secs = int.Parse(cboSekund.Text);


            if (cboSat.Text == "" || cboMinut.Text == "" || cboSekund.Text == "")//here we check if the textboxes are empty
            {
                MessageBox.Show("No correct inputs");
            }
           //if (cboSat.Text != "0" || cboMinut.Text != "0" || cboSekund.Text != "0")
           // {
           //     button1.Enabled = true;
           // }
            
            //else
            //{
            //    timer1.Start();
            //}


            string ssat = cboSat.Text;
            string mminut = cboMinut.Text;
            string ssekund = cboSekund.Text;

            int sat = int.Parse(cboSat.Text);
            int minut = int.Parse(cboMinut.Text);
            int sekund = int.Parse(cboSekund.Text);


            if (radShutdown.Checked == true)
            {
                
DialogResult dialogResult = MessageBox.Show("Da liste sigurni da želite da ugasite računar  za: " + Environment.NewLine +
               "" + ssat + " sati " + mminut + " minuta i " + ssekund + " sekundi","Shutdown ?", MessageBoxButtons.YesNo);

                if (dialogResult==DialogResult.Yes)
                {

                    Process.Start("shutdown", "-s -t " + ZbirSekundi(sat, minut, sekund));
                    lblOpis.Visible = true;
                    lblOpis.Text = "Gašenje za : ";
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                }
              
            }
               

           if (radRestart.Checked == true)
            {
                
                DialogResult dialogResult1 = MessageBox.Show("Da liste sigurni da želite da restartujete  računar  za: " + Environment.NewLine +
               "" + ssat + " sati " + mminut + " minuta i " + ssekund + " sekundi", "Restart ?", MessageBoxButtons.YesNo);

                if (dialogResult1 == DialogResult.Yes)
                {
                    Process.Start("shutdown" ,"-r -t " + ZbirSekundi(sat, minut, sekund));
                    lblOpis.Visible = true;
                    lblOpis.Text = "Restart za : ";
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                }
                
               
            }
           

        }

        private int ZbirSekundi(int a,int b,int c)
        {
            int zbir = a * 3600 + b * 60 + c;
            return zbir;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void radShutdown_Click(object sender, EventArgs e)
        {
            if (radShutdown.Checked)
            {
                button1.Text = "Shut Down";

            }
            else if (radRestart.Checked)
            {
                button1.Text = "Restart";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblOpis.Visible = false;
            timer1.Stop();
            Process.Start("shutdown.exe","-a");
            
        }

        private void radRestart_Click(object sender, EventArgs e)
        {
            button1.Text = "Restart";
        }

        private void radShutdown_Click_1(object sender, EventArgs e)
        {
            button1.Text = "Shut Down";
        }

        private void cboSat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboSat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboSat.Text == "0" && cboMinut.Text == "0" && cboSekund.Text == "0")
            {
                button1.Enabled = false;
            }
            else if (cboSat.Text != "0" || cboMinut.Text != "0" || cboSekund.Text != "0")
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hours == 0 && mins == 0 && secs == 0)
            {
                timer1.Stop();
                MessageBox.Show("Vrijeme je isteklo");
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
            }
            else
            {
                if (secs < 1)// here is the most important code (dont forget to change the timer to 1000 milliseconds)!!! first we check if the secs are smaller than 1
                {
                    secs = 59;// on here we make the secs to 59 if it is smaller than 1
                    if (mins < 1)// here we check if the minutes are smaller than 1
                    {
                        mins = 59;// on here we make the mins to 59 if it is smaller than 1
                        if (hours != 0)// on here we check if the hours are different from 0
                            hours -= 1;// on here we remove from the current hour the number 1. its the same if we write hours = hours - 1;
                    }
                    else mins -= 1;// on here we remove fro mthe current mins 1

                }
                else secs -= 1;// and here we do the same with the seconds
                if (hours > 9)// and on this stage we add the numbers on the labels
                    lblHr.Text = hours.ToString();
                else lblHr.Text = "0" + hours.ToString();
                if (mins > 9)
                    lblMin.Text = mins.ToString();
                else lblMin.Text = "0" + mins.ToString();
                if (secs > 9)
                    lblSec.Text = secs.ToString();
                else lblSec.Text = "0" + secs.ToString();
            }
        }
    }
}
