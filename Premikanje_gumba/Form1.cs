using System.Drawing;
using System.Windows.Forms;

namespace Premikanje_gumba
{
    public partial class Form1: Form
    {
        bool se_premika = false;
        Point prejsnje_koordinate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_MouseDown(object sender, MouseEventArgs e)
        {
            se_premika = true;
            prejsnje_koordinate = e.Location;
            Gumb.Text = "Premakni me!";
        }

        private void Gumb_MouseUp(object sender, MouseEventArgs e)
        {
            se_premika = false;
            Gumb.Text = "Pritisni me!";
        }

        private void Gumb_MouseMove(object sender, MouseEventArgs e)
        {
            if (se_premika)
            {
                Gumb.Left += e.X - prejsnje_koordinate.X;
                Gumb.Top += e.Y - prejsnje_koordinate.Y;
            }
        }
    }
}