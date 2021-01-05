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
            this.buttonKraji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(236, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listBoxKraji
            // 
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.Location = new System.Drawing.Point(73, 84);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(120, 95);
            this.listBoxKraji.TabIndex = 1;
            // 
            // buttonKraji
            // 
            this.buttonKraji.Location = new System.Drawing.Point(73, 300);
            this.buttonKraji.Name = "buttonKraji";
            this.buttonKraji.Size = new System.Drawing.Size(75, 23);
            this.buttonKraji.TabIndex = 2;
            this.buttonKraji.Text = "button1";
            this.buttonKraji.UseVisualStyleBackColor = true;
            this.buttonKraji.Click += new System.EventHandler(this.buttonKraji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKraji);
            this.Controls.Add(this.listBoxKraji);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxKraji;
        private System.Windows.Forms.Button buttonKraji;
    }
}

