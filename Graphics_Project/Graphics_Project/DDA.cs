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
    public partial class DDA : Form
    {
        public DDA()
        {
            InitializeComponent();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            textBoxX2.Clear();
            textBoxY1.Clear();
            textBoxY2.Clear();
            PBDDA.Image = null;
            PBDDA.Invalidate();
            DGViewDDA.DataSource = null;
            DGViewDDA.Rows.Clear();
            DGViewDDA.Refresh();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            int X1, Y1, X2, Y2, DX, DY, step;
            float xi, yi, X, Y; 
            Bitmap p = new Bitmap(PBDDA.Width, PBDDA.Height);
            DGViewDDA.Rows.Clear();
            DGViewDDA.ColumnCount = 3;
            DGViewDDA.Columns[0].Name = "P";
            DGViewDDA.Columns[1].Name = "X";
            DGViewDDA.Columns[2].Name = "Y";
            X1 = int.Parse(textBoxX1.Text);
            Y1 = int.Parse(textBoxY1.Text);
            X2 = int.Parse(textBoxX2.Text);
            Y2 = int.Parse(textBoxY2.Text);
            DX = X2 - X1;
            DY = Y2 - Y1;
            X = X1;
            Y = Y1;
            step = Math.Max(Math.Abs(DX), Math.Abs(DY));
            xi = DX / (float)step;
            yi = DY / (float)step;
            p.SetPixel(X1, X1, Color.Black);
            
            for (int i = 0; i < step; i++)
            {
                X += xi;
                Y +=yi;
                p.SetPixel((int)Math.Round(X), (int)Math.Round(X), Color.Black);
                DGViewDDA.Rows.Add(i, (int)Math.Round(X), (int)Math.Round(Y));
            }
            PBDDA.Image = p;
        }

        private void PBDDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main ma = new Main();
            this.Hide();
            ma.Show();
        }
    }
}
