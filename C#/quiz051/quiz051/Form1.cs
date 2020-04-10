using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {
            var f = new Font(label1.Font.FontFamily, 180);
            label1.Width = 500;
            label1.Height = 50;
            
        }
    }
}
