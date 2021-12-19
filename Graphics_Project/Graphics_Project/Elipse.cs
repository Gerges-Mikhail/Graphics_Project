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
    public partial class Elipse : Form
    {
        public Elipse()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            this.Hide();
            ma.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            textBoxRadiusY.Clear();
            textBoxRadiusX.Clear();
            PBELIPSE.Image = null;
            PBELIPSE.Invalidate();
            DGViewELIPSE.DataSource = null;
            DGViewELIPSE.Rows.Clear();
            DGViewELIPSE.Refresh();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Bitmap elipse = new Bitmap(PBELIPSE.Width, PBELIPSE.Height);
            DGViewELIPSE.Rows.Clear();
            DGViewELIPSE.ColumnCount = 6;
            DGViewELIPSE.Columns[0].Name = "k";
            DGViewELIPSE.Columns[1].Name = "p1k";
            DGViewELIPSE.Columns[2].Name = "xk+1";
            DGViewELIPSE.Columns[3].Name = "yk+1";
            DGViewELIPSE.Columns[4].Name = "2 ry xk+1";
            DGViewELIPSE.Columns[5].Name = "2 rx yk+1";
            int xcentre = PBELIPSE.Width / 2;
            int ycentre = PBELIPSE.Height / 2;
            int radiusx = int.Parse(textBoxRadiusX.Text);
            int radiusy = int.Parse(textBoxRadiusY.Text);
            int p10 = (radiusy * radiusy) - (radiusx * radiusx) * radiusy + ((radiusx * radiusx) / 4);
            int x = 0, y = radiusy;
            int p1k = p10;
            int c = 0;
            while (2 * (radiusy * radiusy) * x < 2 * (radiusx * radiusx) * y)
            {
                elipse.SetPixel(xcentre + x, ycentre + y, Color.Black);
                elipse.SetPixel(xcentre - x, ycentre + y, Color.Black);
                elipse.SetPixel(xcentre + x, ycentre - y, Color.Black);
                elipse.SetPixel(xcentre - x, ycentre - y, Color.Black);
                if (p1k < 0)
                {
                    x++;
                    p1k = p1k + (radiusy * radiusy) * (2 * x + 1);
                    DGViewELIPSE.Rows.Add(c, p1k, x, y, 2 * radiusy * radiusy * x, 2 * radiusx * radiusx * y);
                }
                else
                {
                    x++;
                    y--;
                    p1k = p1k + (radiusy * radiusy) * (2 * x + 1) - 2 * (radiusx * radiusx) * y;
                    DGViewELIPSE.Rows.Add(c, p1k, x, y, 2 * radiusy * radiusy * x, 2 * radiusx * radiusx * y);
                }


            }


            int p20 = (radiusy * radiusy) * ((x + (1 / 2)) * (x + (1 / 2))) + (radiusx * radiusx) * ((y - 1) * (y - 1)) - ((radiusx * radiusx) * (radiusy * radiusy));
            DGViewELIPSE.Rows.Add("region2", "region2", "region2", "region2", "region2", "region2");
            int p2k = p20;
            while (y >= 0)
            {
                elipse.SetPixel(xcentre + x, ycentre + y, Color.Black);
                elipse.SetPixel(xcentre - x, ycentre + y, Color.Black);
                elipse.SetPixel(xcentre + x, ycentre - y, Color.Black);
                elipse.SetPixel(xcentre - x, ycentre - y, Color.Black);
                if (p2k > 0)
                {
                    y--;
                    p2k = p2k - ((radiusx * radiusx) * (2 * y + 1));
                    DGViewELIPSE.Rows.Add(c, p2k, x, y, 2 * radiusy * radiusy * x, 2 * radiusx * radiusx * y);
                }
                else
                {
                    x++;
                    y--;
                    p2k = p2k + 2 * (radiusy * radiusy) * x - (radiusx * radiusx) * (2 * y + 1);
                    DGViewELIPSE.Rows.Add(c, p2k, x, y, 2 * radiusy * radiusy * x, 2 * radiusx * radiusx * y);
                }

            }
            PBELIPSE.Image = elipse;
        }
    }
}
