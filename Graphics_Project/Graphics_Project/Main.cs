using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            DDA d = new DDA();
            this.Hide();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bresenham b = new Bresenham();
            this.Hide();
            b.Show(); 
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Circle b = new Circle();
            this.Hide();
            b.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elipse b = new Elipse();
            this.Hide();
            b.Show(); 
        }
        
    }
}
