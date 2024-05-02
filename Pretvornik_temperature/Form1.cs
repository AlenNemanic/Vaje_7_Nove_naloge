using System;
using System.Windows.Forms;

namespace Pretvornik_temperature
{
    public partial class Form1: Form
    {
        bool iz_celzija_v_fahrenheit = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_pretvori_Click(object sender, EventArgs e)
        {
            if (iz_celzija_v_fahrenheit)
            {
                tekst_fahrenheit.Text = ((double.Parse(tekst_celzija.Text) * 9 / 5) + 32).ToString("#.##");
            }
            else
            {
                tekst_celzija.Text = ((double.Parse(tekst_fahrenheit.Text) - 32) * 5 / 9).ToString("#.##");
            }
        }

        private void tekst_celzija_TextChanged(object sender, EventArgs e)
        {
            iz_celzija_v_fahrenheit = true;
        }

        private void tekst_fahrenheit_TextChanged(object sender, EventArgs e)
        {
            iz_celzija_v_fahrenheit = false;
        }
    }
}