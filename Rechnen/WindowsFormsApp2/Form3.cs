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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            
            double c = Convert.ToDouble(textBox1.Text);
            double d = Convert.ToDouble(textBox5.Text);
            Flaeche.Text = (a * c).ToString();
            Volumen.Text = (a * c * b).ToString();
            Masse.Text = (a * d * b * c).ToString();
        }
    }
}
