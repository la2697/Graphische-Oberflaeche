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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string d = "Quadrat";
            
             string f = "Rechteck";
            String g = "Dreieck";
         

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (listBox1.SelectedItem != null)
            {
                String c = listBox1.SelectedItem.ToString();
                if (c == d)
                {
                    textBox3.Text = (a * a).ToString();
                }

                if (c == f)
                {
                    textBox3.Text = (a * b).ToString();
                }
                if (c == g)
                {
                    textBox3.Text = (a*2*b).ToString();

                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
