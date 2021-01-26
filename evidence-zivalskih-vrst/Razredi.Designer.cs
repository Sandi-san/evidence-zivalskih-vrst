namespace evidence_zivalskih_vrst
{
    partial class Razredi
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonDatabaseUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxRazredi = new System.Windows.Forms.ListBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdateNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxDodajNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(428, 187);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(139, 90);
            this.labelInfo.TabIndex = 21;
            this.labelInfo.Text = "Za posodabljanje in \r\nbrisanje, izberi \r\nvrstico v seznamu \r\nkatero želiš \r\nuprav" +
    "ljati.\r\n";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDatabaseUpdate
            // 
            this.buttonDatabaseUpdate.Location = new System.Drawing.Point(628, 259);
            this.buttonDatabaseUpdate.Name = "buttonDatabaseUpdate";
            this.buttonDatabaseUpdate.Size = new System.Drawing.Size(112, 23);
            this.buttonDatabaseUpdate.TabIndex = 20;
            this.buttonDatabaseUpdate.Text = "Posodobi tabelo";
            this.buttonDatabaseUpdate.UseVisualStyleBackColor = true;
            this.buttonDatabaseUpdate.Click += new System.EventHandler(this.Razredi_Load);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Seznam razredov";
            // 
            // listBoxRazredi
            // 
            this.listBoxRazredi.FormattingEnabled = true;
            this.listBoxRazredi.Location = new System.Drawing.Point(587, 93);
            this.listBoxRazredi.Name = "listBoxRazredi";
            this.listBoxRazredi.Size = new System.Drawing.Size(202, 160);
            this.listBoxRazredi.TabIndex = 18;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(428, 87);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(139, 83);
            this.groupBoxDelete.TabIndex = 16;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Izbriši razred";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(28, 37);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Izbriši";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateNaziv);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Location = new System.Drawing.Point(222, 87);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(190, 145);
            this.groupBoxUpdate.TabIndex = 17;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Posodobi obstoječ razred";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(62, 100);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Posodobi";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdateNaziv
            // 
            this.textBoxUpdateNaziv.Location = new System.Drawing.Point(25, 63);
            this.textBoxUpdateNaziv.MaxLength = 60;
            this.textBoxUpdateNaziv.Name = "textBoxUpdateNaziv";
            this.textBoxUpdateNaziv.Size = new System.Drawing.Size(143, 20);
            this.textBoxUpdateNaziv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Naziv";
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.buttonInsert);
            this.groupBoxInsert.Controls.Add(this.textBoxDodajNaziv);
            this.groupBoxInsert.Controls.Add(this.label1);
            this.groupBoxInsert.Location = new System.Drawing.Point(12, 87);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(190, 145);
            this.groupBoxInsert.TabIndex = 15;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "Dodaj nov razred";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(53, 100);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Dodaj";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxDodajNaziv
            // 
            this.textBoxDodajNaziv.Location = new System.Drawing.Point(25, 63);
            this.textBoxDodajNaziv.MaxLength = 60;
            this.textBoxDodajNaziv.Name = "textBoxDodajNaziv";
            this.textBoxDodajNaziv.Size = new System.Drawing.Size(143, 20);
            this.textBoxDodajNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(315, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 31);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "RAZREDI";
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(331, 259);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(72, 13);
            this.labelBackground.TabIndex = 27;
            this.labelBackground.Text = "l_background";
            this.labelBackground.Visible = false;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(292, 259);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(33, 13);
            this.labelFont.TabIndex = 26;
            this.labelFont.Text = "l_font";
            this.labelFont.Visible = false;
            // 
            // Razredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonDatabaseUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxRazredi);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxInsert);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Razredi";
            this.Text = "Razredi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Razredi_FormClosed);
            this.Load += new System.EventHandler(this.Razredi_Load);
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonDatabaseUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxRazredi;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxDodajNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelFont;
    }
}