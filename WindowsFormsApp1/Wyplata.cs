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
    public partial class Wyplata : Form
    {
        public Wyplata()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int wyplaconaKwota;
            int stan_konta = 12000;
            wyplaconaKwota = Convert.ToInt32(wyplataInput.Text);

            stan_konta -= wyplaconaKwota;
            MessageBox.Show(Convert.ToString(stan_konta));
        }
    }
}
