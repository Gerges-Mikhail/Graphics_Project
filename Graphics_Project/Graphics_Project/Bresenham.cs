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
    public partial class Bresenham : Form
    {
        public Bresenham()
        {
            InitializeComponent();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            textBoxX2.Clear();
            textBoxY1.Clear();
            textBoxY2.Clear();
            PBBR.Image = null;
            PBBR.Invalidate();
            DGViewBR.DataSource = null;
            DGViewBR.Rows.Clear();
            DGViewBR.Refresh();
        }

        private void DGViewDDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int X1, X2, Y1, Y2, DY, DX, STEP;
            DGViewBR.Rows.Clear();
            DGViewBR.ColumnCount = 4;
            DGViewBR.Columns[0].Name = "P";
            DGViewBR.Columns[1].Name = "pk+1";
            DGViewBR.Columns[2].Name = "X";
            DGViewBR.Columns[3].Name = "Y";
            X1 = int.Parse(textBoxX1.Text);
            Y1 = int.Parse(textBoxY1.Text);
            X2 = int.Parse(textBoxX2.Text);
            Y2 = int.Parse(textBoxY2.Text);
            DX = Math.Abs(X2 - X1);
            DY = Math.Abs(Y2 - Y1);
            STEP = Math.Max(DX, DY);
            Bitmap pb = new Bitmap(PBBR.Width, PBBR.Height);
            bool plusOrminusY;
            bool plusOrminusX;
            pb.SetPixel(X1, Y1, Color.Black);
            if (DX > DY)
            {
                int p0 = 2 * DY - DX;
                if (Y1 < Y2)
                {
                    plusOrminusY = true;
                }
                else
                {
                    plusOrminusY = false;
                }
                if (X2 > X1)
                {
                    int pi = p0;
                    for (int j = 0; j < STEP; j++)
                    {
                        X1++;
                        if (pi < 0)
                        {
                            pi = pi + 2 * DY;
                            DGViewBR.Rows.Add(j, pi, X1, Y1);
                        }
                        else
                        {
                            if (plusOrminusY == true)
                            {
                                Y1++;
                            }
                            else
                            {
                                Y1--;
                            }
                            pi = pi + 2 * DY - 2 * DX;
                            pb.SetPixel(X1, Y1, Color.Black);
                            DGViewBR.Rows.Add(j, pi, X1, Y1);
                        }

                    }
                }

            }

            else if (DY > DX)
            {
                int p0 = 2 * DX - DY;
                if (X1 < X2)
                {
                    plusOrminusX = true;
                }
                else
                {
                    plusOrminusX = false;
                }
                if (Y2 > Y1)
                {
                    int pi = p0;
                    for (int j = 0; j < STEP; j++)
                    {
                        Y1++;
                        if (pi < 0)
                        {
                            pi = pi + 2 * DX;
                            DGViewBR.Rows.Add(j, pi, X1, Y1);
                        }
                        else
                        {
                            if (plusOrminusX == true)
                            {
                                X1++;
                            }
                            else
                            {
                                X1--;
                            }
                            pi = pi + 2 * DX - 2 * DY;
                            DGViewBR.Rows.Add(j, pi, X1, Y1);
                        }
                        pb.SetPixel(X1, Y1, Color.Black);
                    }
                }

            }
            PBBR.Image = pb;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            this.Hide();
            ma.Show();
        }
    }
}
