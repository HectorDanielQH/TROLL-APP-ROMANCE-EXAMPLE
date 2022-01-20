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
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (x == 0)
                button2.Location = new Point(294, 123);
            if (x == 1)
                button2.Location = new Point(435, 313);
            if (x == 2)
                button2.Location = new Point(182, 290);
            if (x == 3)
                button2.Location = new Point(42, 184);
            if (x == 4)
                button2.Location = new Point(179, 116);
            if (x == 5)
            {
                button2.Location = new Point(170, 211);
                x = 0;
            }
            x++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SABIA QUE DIRIAS QUE SI MI AMOR!", "ACEPTASTE :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
