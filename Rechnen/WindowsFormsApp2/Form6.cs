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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double t = Convert.ToDouble(textBox4.Text);

            double d = Convert.ToDouble(textBox5.Text);
            Flaeche.Text = ((a+c)*b*0.5).ToString();
            Volumen.Text = ((a + c) * b * 0.5*d).ToString();
            Masse.Text = ((a + c) * b * 0.5 * d*t).ToString();
        }
    }
}
