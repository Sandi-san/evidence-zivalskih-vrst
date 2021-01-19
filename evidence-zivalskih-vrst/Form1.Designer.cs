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
            this.listBoxKraji = new System.Windows.Forms.ListBox();
            this.buttonKrajForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRazredi = new System.Windows.Forms.ListBox();
            this.groupBoxKraji = new System.Windows.Forms.GroupBox();
            this.groupBoxRazredi = new System.Windows.Forms.GroupBox();
            this.buttonRazredForm = new System.Windows.Forms.Button();
            this.buttonVrsteForm = new System.Windows.Forms.Button();
            this.groupBoxKraji.SuspendLayout();
            this.groupBoxRazredi.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxKraji
            // 
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.Location = new System.Drawing.Point(6, 29);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(159, 290);
            this.listBoxKraji.TabIndex = 1;
            // 
            // buttonKrajForm
            // 
            this.buttonKrajForm.Location = new System.Drawing.Point(28, 349);
            this.buttonKrajForm.Name = "buttonKrajForm";
            this.buttonKrajForm.Size = new System.Drawing.Size(114, 23);
            this.buttonKrajForm.TabIndex = 2;
            this.buttonKrajForm.Text = "Upravljaj kraje";
            this.buttonKrajForm.UseVisualStyleBackColor = true;
            this.buttonKrajForm.Click += new System.EventHandler(this.buttonKrajForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Živalski razred";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Živalska vrsta";
            // 
            // listBoxRazredi
            // 
            this.listBoxRazredi.FormattingEnabled = true;
            this.listBoxRazredi.Location = new System.Drawing.Point(6, 29);
            this.listBoxRazredi.Name = "listBoxRazredi";
            this.listBoxRazredi.Size = new System.Drawing.Size(159, 290);
            this.listBoxRazredi.TabIndex = 12;
            // 
            // groupBoxKraji
            // 
            this.groupBoxKraji.Controls.Add(this.listBoxKraji);
            this.groupBoxKraji.Controls.Add(this.buttonKrajForm);
            this.groupBoxKraji.Location = new System.Drawing.Point(16, 14);
            this.groupBoxKraji.Name = "groupBoxKraji";
            this.groupBoxKraji.Size = new System.Drawing.Size(171, 388);
            this.groupBoxKraji.TabIndex = 13;
            this.groupBoxKraji.TabStop = false;
            this.groupBoxKraji.Text = "Kraji";
            // 
            // groupBoxRazredi
            // 
            this.groupBoxRazredi.Controls.Add(this.buttonRazredForm);
            this.groupBoxRazredi.Controls.Add(this.listBoxRazredi);
            this.groupBoxRazredi.Location = new System.Drawing.Point(193, 14);
            this.groupBoxRazredi.Name = "groupBoxRazredi";
            this.groupBoxRazredi.Size = new System.Drawing.Size(171, 388);
            this.groupBoxRazredi.TabIndex = 14;
            this.groupBoxRazredi.TabStop = false;
            this.groupBoxRazredi.Text = "Razredi";
            // 
            // buttonRazredForm
            // 
            this.buttonRazredForm.Location = new System.Drawing.Point(24, 349);
            this.buttonRazredForm.Name = "buttonRazredForm";
            this.buttonRazredForm.Size = new System.Drawing.Size(114, 23);
            this.buttonRazredForm.TabIndex = 15;
            this.buttonRazredForm.Text = "Upravljaj razrede";
            this.buttonRazredForm.UseVisualStyleBackColor = true;
            this.buttonRazredForm.Click += new System.EventHandler(this.buttonRazredForm_Click);
            // 
            // buttonVrsteForm
            // 
            this.buttonVrsteForm.Location = new System.Drawing.Point(393, 363);
            this.buttonVrsteForm.Name = "buttonVrsteForm";
            this.buttonVrsteForm.Size = new System.Drawing.Size(114, 23);
            this.buttonVrsteForm.TabIndex = 16;
            this.buttonVrsteForm.Text = "Upravljaj vrste";
            this.buttonVrsteForm.UseVisualStyleBackColor = true;
            this.buttonVrsteForm.Click += new System.EventHandler(this.buttonVrsteForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVrsteForm);
            this.Controls.Add(this.groupBoxRazredi);
            this.Controls.Add(this.groupBoxKraji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKraji.ResumeLayout(false);
            this.groupBoxRazredi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxKraji;
        private System.Windows.Forms.Button buttonKrajForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRazredi;
        private System.Windows.Forms.GroupBox groupBoxKraji;
        private System.Windows.Forms.GroupBox groupBoxRazredi;
        private System.Windows.Forms.Button buttonRazredForm;
        private System.Windows.Forms.Button buttonVrsteForm;
    }
}

