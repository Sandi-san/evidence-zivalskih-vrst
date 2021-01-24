namespace evidence_zivalskih_vrst
{
    partial class NovKraj
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxDodajIme = new System.Windows.Forms.TextBox();
            this.textBoxDodajPosta = new System.Windows.Forms.TextBox();
            this.textBoxDodajVelUporab = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.textBoxUpdateVelUporab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUpdatePosta = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxKraji = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDatabaseUpdate = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.groupBoxInsert.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(59, 271);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Dodaj";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxDodajIme
            // 
            this.textBoxDodajIme.Location = new System.Drawing.Point(25, 63);
            this.textBoxDodajIme.MaxLength = 60;
            this.textBoxDodajIme.Name = "textBoxDodajIme";
            this.textBoxDodajIme.Size = new System.Drawing.Size(143, 20);
            this.textBoxDodajIme.TabIndex = 1;
            // 
            // textBoxDodajPosta
            // 
            this.textBoxDodajPosta.Location = new System.Drawing.Point(25, 132);
            this.textBoxDodajPosta.MaxLength = 4;
            this.textBoxDodajPosta.Name = "textBoxDodajPosta";
            this.textBoxDodajPosta.Size = new System.Drawing.Size(143, 20);
            this.textBoxDodajPosta.TabIndex = 2;
            // 
            // textBoxDodajVelUporab
            // 
            this.textBoxDodajVelUporab.Location = new System.Drawing.Point(25, 207);
            this.textBoxDodajVelUporab.MaxLength = 80;
            this.textBoxDodajVelUporab.Name = "textBoxDodajVelUporab";
            this.textBoxDodajVelUporab.Size = new System.Drawing.Size(143, 20);
            this.textBoxDodajVelUporab.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(315, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 31);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "KRAJI";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Poštna številka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veliki uporabniki (podjetja)";
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.textBoxDodajVelUporab);
            this.groupBoxInsert.Controls.Add(this.label3);
            this.groupBoxInsert.Controls.Add(this.buttonInsert);
            this.groupBoxInsert.Controls.Add(this.label2);
            this.groupBoxInsert.Controls.Add(this.textBoxDodajIme);
            this.groupBoxInsert.Controls.Add(this.label1);
            this.groupBoxInsert.Controls.Add(this.textBoxDodajPosta);
            this.groupBoxInsert.Location = new System.Drawing.Point(12, 81);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(190, 326);
            this.groupBoxInsert.TabIndex = 8;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "Dodaj nov kraj";
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateVelUporab);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateIme);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdatePosta);
            this.groupBoxUpdate.Location = new System.Drawing.Point(222, 81);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(190, 326);
            this.groupBoxUpdate.TabIndex = 9;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Posodobi obstoječ kraj";
            // 
            // textBoxUpdateVelUporab
            // 
            this.textBoxUpdateVelUporab.Location = new System.Drawing.Point(25, 207);
            this.textBoxUpdateVelUporab.MaxLength = 80;
            this.textBoxUpdateVelUporab.Name = "textBoxUpdateVelUporab";
            this.textBoxUpdateVelUporab.Size = new System.Drawing.Size(143, 20);
            this.textBoxUpdateVelUporab.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Veliki uporabniki (podjetja)";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(59, 271);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Posodobi";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Poštna številka";
            // 
            // textBoxUpdateIme
            // 
            this.textBoxUpdateIme.Location = new System.Drawing.Point(25, 63);
            this.textBoxUpdateIme.MaxLength = 60;
            this.textBoxUpdateIme.Name = "textBoxUpdateIme";
            this.textBoxUpdateIme.Size = new System.Drawing.Size(143, 20);
            this.textBoxUpdateIme.TabIndex = 1;
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
            // textBoxUpdatePosta
            // 
            this.textBoxUpdatePosta.Location = new System.Drawing.Point(25, 132);
            this.textBoxUpdatePosta.MaxLength = 4;
            this.textBoxUpdatePosta.Name = "textBoxUpdatePosta";
            this.textBoxUpdatePosta.Size = new System.Drawing.Size(143, 20);
            this.textBoxUpdatePosta.TabIndex = 2;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(428, 81);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(139, 83);
            this.groupBoxDelete.TabIndex = 9;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Izbriši kraj";
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
            // listBoxKraji
            // 
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.Location = new System.Drawing.Point(587, 87);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(202, 277);
            this.listBoxKraji.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Seznam krajev";
            // 
            // buttonDatabaseUpdate
            // 
            this.buttonDatabaseUpdate.Location = new System.Drawing.Point(637, 370);
            this.buttonDatabaseUpdate.Name = "buttonDatabaseUpdate";
            this.buttonDatabaseUpdate.Size = new System.Drawing.Size(112, 23);
            this.buttonDatabaseUpdate.TabIndex = 12;
            this.buttonDatabaseUpdate.Text = "Posodobi tabelo";
            this.buttonDatabaseUpdate.UseVisualStyleBackColor = true;
            this.buttonDatabaseUpdate.Click += new System.EventHandler(this.NovKraj_Load);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(425, 211);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(139, 90);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "Za posodabljanje in \r\nbrisanje, izberi \r\nvrstico v seznamu \r\nkatero želiš \r\nuprav" +
    "ljati.";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(476, 414);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(72, 13);
            this.labelBackground.TabIndex = 25;
            this.labelBackground.Text = "l_background";
            this.labelBackground.Visible = false;
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(437, 414);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(33, 13);
            this.labelFont.TabIndex = 24;
            this.labelFont.Text = "l_font";
            this.labelFont.Visible = false;
            // 
            // NovKraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonDatabaseUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxKraji);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxInsert);
            this.Controls.Add(this.labelTitle);
            this.Name = "NovKraj";
            this.Text = "NovKraj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NovKraj_FormClosed);
            this.Load += new System.EventHandler(this.NovKraj_Load);
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxDodajIme;
        private System.Windows.Forms.TextBox textBoxDodajPosta;
        private System.Windows.Forms.TextBox textBoxDodajVelUporab;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateVelUporab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUpdatePosta;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxKraji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDatabaseUpdate;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelFont;
    }
}