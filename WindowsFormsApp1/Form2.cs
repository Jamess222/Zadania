using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string srodki = "12000";
            stanKonta.Text = srodki;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void stan_konta_Click(object sender, EventArgs e)
        {
            Konto konto = new Konto();
            konto.Show();
        }

        private void wplata_Click(object sender, EventArgs e)
        {
            Wplata wplata = new Wplata();
            wplata.Show();
        }

        private void wyplata_Click(object sender, EventArgs e)
        {
            Wyplata wyplata = new Wyplata();
            wyplata.Show();
        }

        private void przelew_Click(object sender, EventArgs e)
        {
            Przelew przelew = new Przelew();
            przelew.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
