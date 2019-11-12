using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double c = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double t = 3.14;
            Flaeche.Text = (0.25*t*c*c).ToString();
            Volumen.Text = (0.25 * t * c * c*a).ToString();
            Masse.Text = (0.25 * t * c * c * a*b).ToString();
        }
    }
}
