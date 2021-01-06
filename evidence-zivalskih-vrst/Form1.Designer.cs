namespace evidence_zivalskih_vrst
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxKraji = new System.Windows.Forms.ListBox();
            this.buttonKrajNov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKrajIme = new System.Windows.Forms.TextBox();
            this.textBoxKrajPosta = new System.Windows.Forms.TextBox();
            this.textBoxKrajVelUporab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listBoxKraji
            // 
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.Location = new System.Drawing.Point(380, 93);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(120, 95);
            this.listBoxKraji.TabIndex = 1;
            // 
            // buttonKrajNov
            // 
            this.buttonKrajNov.Location = new System.Drawing.Point(407, 242);
            this.buttonKrajNov.Name = "buttonKrajNov";
            this.buttonKrajNov.Size = new System.Drawing.Size(75, 23);
            this.buttonKrajNov.TabIndex = 2;
            this.buttonKrajNov.Text = "Nov kraj";
            this.buttonKrajNov.UseVisualStyleBackColor = true;
            this.buttonKrajNov.Click += new System.EventHandler(this.buttonKrajNov_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Živalski razred";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Živalska vrsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kraji";
            // 
            // textBoxKrajIme
            // 
            this.textBoxKrajIme.Location = new System.Drawing.Point(337, 358);
            this.textBoxKrajIme.Name = "textBoxKrajIme";
            this.textBoxKrajIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxKrajIme.TabIndex = 6;
            // 
            // textBoxKrajPosta
            // 
            this.textBoxKrajPosta.Location = new System.Drawing.Point(502, 358);
            this.textBoxKrajPosta.Name = "textBoxKrajPosta";
            this.textBoxKrajPosta.Size = new System.Drawing.Size(100, 20);
            this.textBoxKrajPosta.TabIndex = 7;
            // 
            // textBoxKrajVelUporab
            // 
            this.textBoxKrajVelUporab.Location = new System.Drawing.Point(636, 358);
            this.textBoxKrajVelUporab.Name = "textBoxKrajVelUporab";
            this.textBoxKrajVelUporab.Size = new System.Drawing.Size(100, 20);
            this.textBoxKrajVelUporab.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "velupor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKrajVelUporab);
            this.Controls.Add(this.textBoxKrajPosta);
            this.Controls.Add(this.textBoxKrajIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKrajNov);
            this.Controls.Add(this.listBoxKraji);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxKraji;
        private System.Windows.Forms.Button buttonKrajNov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKrajIme;
        private System.Windows.Forms.TextBox textBoxKrajPosta;
        private System.Windows.Forms.TextBox textBoxKrajVelUporab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

