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
            string t = "Kreis";
            string h = "Trapez";

            Form2 form2 = new Form2();
            Form3 form3= new Form3();
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            Form6 form6 = new Form6();


            if (listBox1.SelectedItem != null)
            {
                String c = listBox1.SelectedItem.ToString();
                if (c == d)
                {
                    form2.Show();
                }
                if (c == f)
                {
                    form3.Show();
                }
                if (c == g)
                {
                    form4.Show();
                }
                if (c == t)
                {
                    form5.Show();
                }
                if (c ==h)
                {
                    form6.Show();
                }
            }
        }
    }
}
