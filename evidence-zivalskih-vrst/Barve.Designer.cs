namespace evidence_zivalskih_vrst
{
    partial class Barve
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
            this.textBoxBackground = new System.Windows.Forms.TextBox();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBackground
            // 
            this.textBoxBackground.Location = new System.Drawing.Point(102, 74);
            this.textBoxBackground.Name = "textBoxBackground";
            this.textBoxBackground.Size = new System.Drawing.Size(100, 20);
            this.textBoxBackground.TabIndex = 0;
            // 
            // textBoxFont
            // 
            this.textBoxFont.Location = new System.Drawing.Point(102, 35);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(100, 20);
            this.textBoxFont.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barva pisave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barva ozadja:";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(74, 125);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeColor.TabIndex = 4;
            this.buttonChangeColor.Text = "Uporabi";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(227, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vnešene barve naj \r\nbodo le v majhnih\r\ntiskanih črkah\r\nin slogovno pravilne.";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(250, 135);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(72, 13);
            this.labelBackground.TabIndex = 25;
            this.labelBackground.Text = "l_background";
            this.labelBackground.Visible = false;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(211, 135);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(33, 13);
            this.labelFont.TabIndex = 24;
            this.labelFont.Text = "l_font";
            this.labelFont.Visible = false;
            // 
            // Barve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 167);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.textBoxBackground);
            this.Name = "Barve";
            this.Text = "Barve";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Barve_FormClosed);
            this.Load += new System.EventHandler(this.Barve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBackground;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelFont;
    }
}