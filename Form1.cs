using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace wyscigg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool started = false;
        private void button1_Click(object sender, EventArgs e)
        {
            startSettings();
            started = true;
            while(started == true)
            {
                Run();
                Thread.Sleep(5);
            }
            checkWin();
            
        }

        public void startSettings()
        {
            pies1.Left = 0;
            pies2.Left = 0;
            pies3.Left = 0;
            pies4.Left = 0;
        }

        public int wygrany = 0;

        public void Check(int pies1, int pies2, int pies3, int pies4)
        {
            if(pies1 >= 500)
            {
                started = false;
                MessageBox.Show("Wygral pies nr 1");
                wygrany = 1;
            }
            else if (pies2 >= 500)
            {
                started = false;
                MessageBox.Show("Wygral pies nr 2");
                wygrany = 2;
            }
            else if (pies3 >= 500)
            {
                started = false;
                MessageBox.Show("Wygral pies nr 3");
                wygrany = 3;
            }
            else if (pies4 >= 500)
            {
                started = false;
                MessageBox.Show("Wygral pies nr 4");
                wygrany = 4;
            }
        }


        public void checkWin()
        {
            string player = name.Text;
            decimal kasa = numericUpDown1.Value;
            decimal pies = numericUpDown2.Value;

            int laczna = (Convert.ToInt32(suma) + (Convert.ToInt32(kwota) * 2));
            int laczna2 = (Convert.ToInt32(suma2) + (Convert.ToInt32(kwota) * 2));
            int laczna3 = (Convert.ToInt32(suma3) + (Convert.ToInt32(kwota) * 2));

            switch (player)
            {
                case "JAMES":

                    if(pies == wygrany)
                    {
                        jamesButton.Text = "James ma: " + laczna;
                    }

                break;

                case "MARTIN":

                    if (pies == wygrany)
                    {
                        martinButton.Text = "Martin ma: " + laczna2;
                    }
                    break;

                case "JOHN":

                    if (pies == wygrany)
                    {
                        johnButton.Text = "John ma: " + laczna3;
                    }
                    break;
            }
            
        }

        public void Run()
        {
            Random random1 = new Random();
            pies1.Left += random1.Next(3, 30);

            Random random2 = new Random();
            pies2.Left += random2.Next(3, 10);

            Random random3 = new Random();
            pies3.Left += random3.Next(3, 10);

            Random random4 = new Random();
            pies4.Left += random4.Next(3, 10);
            
            Check(pies1.Left, pies2.Left, pies3.Left, pies4.Left);
        }

        public int stanJ = 500;
        public int stanM = 1000;
        public int stanJN = 350;

        private void jamesButton_CheckedChanged(object sender, EventArgs e)
        {
            jamesButton.Text = "James ma: " + stanJ;
        }

        private void martinButton_CheckedChanged(object sender, EventArgs e)
        {
            martinButton.Text = "Martin ma: " + stanM;
        }

        private void johnButton_CheckedChanged(object sender, EventArgs e)
        {
            johnButton.Text = "John ma: " + stanJN;
        }
        public int suma;
        public int suma2;
        public int suma3;
        public decimal kwota;
        private void betButton_Click(object sender, EventArgs e)
        {
            if (jamesButton.Checked)
            {
                string gracz = name.Text = "JAMES";
                kwota = numericUpDown1.Value;
                decimal nr = numericUpDown2.Value; 
                jamesBetLabel.Text = gracz + " postawił " +kwota + "zł na psa nr" +nr;
                suma = stanJ - Convert.ToInt32(kwota);
                jamesButton.Text = "James ma " + suma;
               
            }

            if (martinButton.Checked)
            {
                string gracz = name.Text = "MARTIN";
                decimal kwota = numericUpDown1.Value;
                decimal nr = numericUpDown2.Value;
                martinBetLabel.Text = gracz + " postawił " + kwota + "zł na psa nr" + nr;
                suma2 = stanM - Convert.ToInt32(kwota);
                martinButton.Text = "Martin ma " + suma2;
            }

            if (johnButton.Checked)
            {
                string gracz = name.Text = "JOHN";
                decimal kwota = numericUpDown1.Value;
                decimal nr = numericUpDown2.Value;
                johnBetLabel.Text = gracz + " postawił " + kwota + "zł na psa nr" + nr;
                suma3 = stanJN - Convert.ToInt32(kwota);
                johnButton.Text = "John ma " + suma3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
