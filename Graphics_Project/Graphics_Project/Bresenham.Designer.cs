namespace Graphics_Project
{
    partial class Bresenham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bresenham));
            this.CLEAR = new System.Windows.Forms.Button();
            this.DGViewBR = new System.Windows.Forms.DataGridView();
            this.PBBR = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBR)).BeginInit();
            this.SuspendLayout();
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.LightCoral;
            this.CLEAR.Location = new System.Drawing.Point(636, 8);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(52, 23);
            this.CLEAR.TabIndex = 84;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DGViewBR
            // 
            this.DGViewBR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewBR.Location = new System.Drawing.Point(380, 36);
            this.DGViewBR.Name = "DGViewBR";
            this.DGViewBR.Size = new System.Drawing.Size(364, 393);
            this.DGViewBR.TabIndex = 82;
            this.DGViewBR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGViewDDA_CellContentClick);
            // 
            // PBBR
            // 
            this.PBBR.BackColor = System.Drawing.Color.White;
            this.PBBR.Location = new System.Drawing.Point(9, 36);
            this.PBBR.Name = "PBBR";
            this.PBBR.Size = new System.Drawing.Size(365, 393);
            this.PBBR.TabIndex = 83;
            this.PBBR.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(380, 8);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(74, 23);
            this.buttonDraw.TabIndex = 80;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(694, 8);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(50, 23);
            this.EXIT.TabIndex = 81;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(284, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Y2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Y1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(188, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "X2";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelX1.Location = new System.Drawing.Point(12, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(24, 17);
            this.labelX1.TabIndex = 90;
            this.labelX1.Text = "X1";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(314, 11);
            this.textBoxY2.Multiline = true;
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(44, 19);
            this.textBoxY2.TabIndex = 92;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(127, 11);
            this.textBoxY1.Multiline = true;
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(45, 17);
            this.textBoxY1.TabIndex = 86;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(218, 12);
            this.textBoxX2.Multiline = true;
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(46, 17);
            this.textBoxX2.TabIndex = 91;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(42, 12);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(46, 17);
            this.textBoxX1.TabIndex = 85;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Cyan;
            this.buttonBack.Location = new System.Drawing.Point(546, 8);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 23);
            this.buttonBack.TabIndex = 93;
            this.buttonBack.Text = "Back to Home";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Bresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(753, 436);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DGViewBR);
            this.Controls.Add(this.PBBR);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.EXIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bresenham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bresenham";
            ((System.ComponentModel.ISupportInitialize)(this.DGViewBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.DataGridView DGViewBR;
        private System.Windows.Forms.PictureBox PBBR;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Button buttonBack;
    }
}