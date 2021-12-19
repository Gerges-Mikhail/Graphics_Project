namespace Graphics_Project
{
    partial class Elipse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elipse));
            this.buttonBack = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.DGViewELIPSE = new System.Windows.Forms.DataGridView();
            this.PBELIPSE = new System.Windows.Forms.PictureBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxRadiusY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBoxRadiusX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewELIPSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBELIPSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Cyan;
            this.buttonBack.Location = new System.Drawing.Point(839, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 23);
            this.buttonBack.TabIndex = 93;
            this.buttonBack.Text = "Back to Home";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.LightCoral;
            this.CLEAR.Location = new System.Drawing.Point(929, 11);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(52, 23);
            this.CLEAR.TabIndex = 92;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DGViewELIPSE
            // 
            this.DGViewELIPSE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewELIPSE.Location = new System.Drawing.Point(383, 35);
            this.DGViewELIPSE.Name = "DGViewELIPSE";
            this.DGViewELIPSE.Size = new System.Drawing.Size(655, 393);
            this.DGViewELIPSE.TabIndex = 90;
            // 
            // PBELIPSE
            // 
            this.PBELIPSE.BackColor = System.Drawing.Color.White;
            this.PBELIPSE.Location = new System.Drawing.Point(12, 35);
            this.PBELIPSE.Name = "PBELIPSE";
            this.PBELIPSE.Size = new System.Drawing.Size(365, 393);
            this.PBELIPSE.TabIndex = 91;
            this.PBELIPSE.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelX1.Location = new System.Drawing.Point(12, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 19);
            this.labelX1.TabIndex = 87;
            this.labelX1.Text = "Radius X ";
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(987, 11);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(50, 23);
            this.EXIT.TabIndex = 89;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(383, 11);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(60, 23);
            this.buttonDraw.TabIndex = 88;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxRadiusY
            // 
            this.textBoxRadiusY.Location = new System.Drawing.Point(103, 11);
            this.textBoxRadiusY.Multiline = true;
            this.textBoxRadiusY.Name = "textBoxRadiusY";
            this.textBoxRadiusY.Size = new System.Drawing.Size(79, 20);
            this.textBoxRadiusY.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(188, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Radius Y ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBoxRadiusX
            // 
            this.textBoxRadiusX.Location = new System.Drawing.Point(277, 11);
            this.textBoxRadiusX.Name = "textBoxRadiusX";
            this.textBoxRadiusX.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadiusX.TabIndex = 94;
            // 
            // Elipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1049, 436);
            this.Controls.Add(this.textBoxRadiusX);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DGViewELIPSE);
            this.Controls.Add(this.PBELIPSE);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxRadiusY);
            this.Controls.Add(this.EXIT);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Elipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E L I P S E ";
            ((System.ComponentModel.ISupportInitialize)(this.DGViewELIPSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBELIPSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.DataGridView DGViewELIPSE;
        private System.Windows.Forms.PictureBox PBELIPSE;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxRadiusY;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBoxRadiusX;
    }
}