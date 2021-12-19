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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            textBoxRadius.Clear();
            
            PBCIRCLE.Image = null;
            PBCIRCLE.Invalidate();
            DGViewCIRCLE.DataSource = null;
            DGViewCIRCLE.Rows.Clear();
            DGViewCIRCLE.Refresh();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int xcentre, ycentre, radius;
            DGViewCIRCLE.Rows.Clear();
            DGViewCIRCLE.ColumnCount = 4;
            DGViewCIRCLE.Columns[0].Name = "P";
            DGViewCIRCLE.Columns[1].Name = "p1k";
            DGViewCIRCLE.Columns[2].Name = "xk+1";
            DGViewCIRCLE.Columns[3].Name = "yk+1";
            xcentre = PBCIRCLE.Width / 2;
            ycentre = PBCIRCLE.Height / 2;
            radius = int.Parse(textBoxRadius.Text);
            Bitmap pc = new Bitmap(PBCIRCLE.Width, PBCIRCLE.Height);
            int x = radius, y = 0;
            int p0 = 1 - radius;
            int P = p0;
            DGViewCIRCLE.Rows.Add(0, P, x, y);
            int c = 1;
            while (x > y)
            {
                pc.SetPixel(xcentre + x, ycentre + y, Color.Black);
                pc.SetPixel(xcentre - x, ycentre + y, Color.Black);
                pc.SetPixel(xcentre + x, ycentre - y, Color.Black);
                pc.SetPixel(xcentre - x, ycentre - y, Color.Black);
                pc.SetPixel(xcentre + y, ycentre + x, Color.Black);
                pc.SetPixel(xcentre - y, ycentre + x, Color.Black);
                pc.SetPixel(xcentre + y, ycentre - x, Color.Black);
                pc.SetPixel(xcentre - y, ycentre - x, Color.Black);
                if (P <= 0)
                {
                    y++;
                    P = P + 2 * (y + 1) + 1;
                    DGViewCIRCLE.Rows.Add(c, P, x, y);
                }
                else
                {
                    x--;
                    y++;
                    P = P + 2 * (y + 1) - 2 * (x - 1) + 1;
                    DGViewCIRCLE.Rows.Add(c, P, x, y);
                }

            }
            PBCIRCLE.Image = pc;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            this.Hide();
            ma.Show();
        }
    }
}
