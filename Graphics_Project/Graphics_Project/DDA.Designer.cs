namespace Graphics_Project
{
    partial class DDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDA));
            this.CLEAR = new System.Windows.Forms.Button();
            this.DGViewDDA = new System.Windows.Forms.DataGridView();
            this.PBDDA = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewDDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDDA)).BeginInit();
            this.SuspendLayout();
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.LightCoral;
            this.CLEAR.Location = new System.Drawing.Point(635, 20);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(52, 23);
            this.CLEAR.TabIndex = 71;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DGViewDDA
            // 
            this.DGViewDDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewDDA.Location = new System.Drawing.Point(380, 45);
            this.DGViewDDA.Name = "DGViewDDA";
            this.DGViewDDA.Size = new System.Drawing.Size(364, 393);
            this.DGViewDDA.TabIndex = 69;
            // 
            // PBDDA
            // 
            this.PBDDA.BackColor = System.Drawing.Color.White;
            this.PBDDA.Location = new System.Drawing.Point(9, 45);
            this.PBDDA.Name = "PBDDA";
            this.PBDDA.Size = new System.Drawing.Size(365, 393);
            this.PBDDA.TabIndex = 70;
            this.PBDDA.TabStop = false;
            this.PBDDA.Click += new System.EventHandler(this.PBDDA_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(384, 16);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(60, 23);
            this.buttonDraw.TabIndex = 67;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(693, 20);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(50, 23);
            this.EXIT.TabIndex = 68;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(42, 19);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(46, 17);
            this.textBoxX1.TabIndex = 59;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(221, 20);
            this.textBoxX2.Multiline = true;
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(46, 17);
            this.textBoxX2.TabIndex = 65;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(127, 18);
            this.textBoxY1.Multiline = true;
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(45, 17);
            this.textBoxY1.TabIndex = 60;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(314, 18);
            this.textBoxY2.Multiline = true;
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(44, 19);
            this.textBoxY2.TabIndex = 66;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelX1.Location = new System.Drawing.Point(12, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(24, 17);
            this.labelX1.TabIndex = 64;
            this.labelX1.Text = "X1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "X2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(284, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Y2";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Cyan;
            this.buttonBack.Location = new System.Drawing.Point(545, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 23);
            this.buttonBack.TabIndex = 72;
            this.buttonBack.Text = "Back to Home";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // DDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(749, 442);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DGViewDDA);
            this.Controls.Add(this.PBDDA);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.EXIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDA";
            ((System.ComponentModel.ISupportInitialize)(this.DGViewDDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.DataGridView DGViewDDA;
        private System.Windows.Forms.PictureBox PBDDA;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
    }
}