using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void Button1_Click(object sender, EventArgs e)
        {

            if ((int.TryParse(textBox1.Text, out var x)) && (int.TryParse(textBox2.Text, out var y)))

            {

                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a * b;
                label2.Text = "= " + c;
            }
            else
            {

                label2.Text = "= Error";
            }



        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
