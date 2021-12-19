namespace Graphics_Project
{
    partial class Circle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circle));
            this.CLEAR = new System.Windows.Forms.Button();
            this.DGViewCIRCLE = new System.Windows.Forms.DataGridView();
            this.PBCIRCLE = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewCIRCLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCIRCLE)).BeginInit();
            this.SuspendLayout();
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.Color.LightCoral;
            this.CLEAR.Location = new System.Drawing.Point(732, 5);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(52, 23);
            this.CLEAR.TabIndex = 84;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // DGViewCIRCLE
            // 
            this.DGViewCIRCLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewCIRCLE.Location = new System.Drawing.Point(383, 33);
            this.DGViewCIRCLE.Name = "DGViewCIRCLE";
            this.DGViewCIRCLE.Size = new System.Drawing.Size(457, 393);
            this.DGViewCIRCLE.TabIndex = 82;
            // 
            // PBCIRCLE
            // 
            this.PBCIRCLE.BackColor = System.Drawing.Color.White;
            this.PBCIRCLE.Location = new System.Drawing.Point(12, 33);
            this.PBCIRCLE.Name = "PBCIRCLE";
            this.PBCIRCLE.Size = new System.Drawing.Size(365, 393);
            this.PBCIRCLE.TabIndex = 83;
            this.PBCIRCLE.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(167, 5);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(60, 23);
            this.buttonDraw.TabIndex = 80;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelX1.Location = new System.Drawing.Point(12, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 19);
            this.labelX1.TabIndex = 77;
            this.labelX1.Text = "Radius";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(82, 7);
            this.textBoxRadius.Multiline = true;
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(79, 20);
            this.textBoxRadius.TabIndex = 72;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(790, 5);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(50, 23);
            this.EXIT.TabIndex = 81;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Cyan;
            this.buttonBack.Location = new System.Drawing.Point(642, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 23);
            this.buttonBack.TabIndex = 85;
            this.buttonBack.Text = "Back to Home";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(843, 430);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.DGViewCIRCLE);
            this.Controls.Add(this.PBCIRCLE);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.EXIT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Circle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle";
            ((System.ComponentModel.ISupportInitialize)(this.DGViewCIRCLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCIRCLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.DataGridView DGViewCIRCLE;
        private System.Windows.Forms.PictureBox PBCIRCLE;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button buttonBack;
    }
}