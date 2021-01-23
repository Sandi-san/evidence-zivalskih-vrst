namespace evidence_zivalskih_vrst
{
    partial class Vrste
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
            this.listBoxVrste = new System.Windows.Forms.ListBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.listBoxUpdateKraj = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxUpdateRazred = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUpdateIme = new System.Windows.Forms.TextBox();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.listBoxDodajKraj = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDodajRazred = new System.Windows.Forms.ListBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDodajIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(425, 217);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(139, 90);
            this.labelInfo.TabIndex = 21;
            this.labelInfo.Text = "Za posodabljanje in \r\nbrisanje, izberi \r\nvrstico v seznamu \r\nkatero želiš \r\nuprav" +
    "ljati.";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDatabaseUpdate
            // 
            this.buttonDatabaseUpdate.Location = new System.Drawing.Point(637, 376);
            this.buttonDatabaseUpdate.Name = "buttonDatabaseUpdate";
            this.buttonDatabaseUpdate.Size = new System.Drawing.Size(112, 23);
            this.buttonDatabaseUpdate.TabIndex = 20;
            this.buttonDatabaseUpdate.Text = "Posodobi tabelo";
            this.buttonDatabaseUpdate.UseVisualStyleBackColor = true;
            this.buttonDatabaseUpdate.Click += new System.EventHandler(this.UpdateTabela);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Seznam vrste";
            // 
            // listBoxVrste
            // 
            this.listBoxVrste.FormattingEnabled = true;
            this.listBoxVrste.Location = new System.Drawing.Point(587, 93);
            this.listBoxVrste.Name = "listBoxVrste";
            this.listBoxVrste.Size = new System.Drawing.Size(202, 277);
            this.listBoxVrste.TabIndex = 18;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(428, 87);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(139, 83);
            this.groupBoxDelete.TabIndex = 16;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Izbriši vrsto";
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
            this.groupBoxUpdate.Controls.Add(this.listBoxUpdateKraj);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.listBoxUpdateRazred);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateIme);
            this.groupBoxUpdate.Location = new System.Drawing.Point(222, 87);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(190, 351);
            this.groupBoxUpdate.TabIndex = 17;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Posodobi obstoječo vrsto";
            // 
            // listBoxUpdateKraj
            // 
            this.listBoxUpdateKraj.FormattingEnabled = true;
            this.listBoxUpdateKraj.Location = new System.Drawing.Point(25, 207);
            this.listBoxUpdateKraj.Name = "listBoxUpdateKraj";
            this.listBoxUpdateKraj.Size = new System.Drawing.Size(140, 82);
            this.listBoxUpdateKraj.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kraj";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(55, 311);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Posodobi";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listBoxUpdateRazred
            // 
            this.listBoxUpdateRazred.FormattingEnabled = true;
            this.listBoxUpdateRazred.Location = new System.Drawing.Point(28, 96);
            this.listBoxUpdateRazred.Name = "listBoxUpdateRazred";
            this.listBoxUpdateRazred.Size = new System.Drawing.Size(140, 82);
            this.listBoxUpdateRazred.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Razred";
            // 
            // textBoxUpdateIme
            // 
            this.textBoxUpdateIme.Location = new System.Drawing.Point(25, 44);
            this.textBoxUpdateIme.MaxLength = 60;
            this.textBoxUpdateIme.Name = "textBoxUpdateIme";
            this.textBoxUpdateIme.Size = new System.Drawing.Size(143, 20);
            this.textBoxUpdateIme.TabIndex = 26;
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.listBoxDodajKraj);
            this.groupBoxInsert.Controls.Add(this.label3);
            this.groupBoxInsert.Controls.Add(this.listBoxDodajRazred);
            this.groupBoxInsert.Controls.Add(this.buttonInsert);
            this.groupBoxInsert.Controls.Add(this.label2);
            this.groupBoxInsert.Controls.Add(this.textBoxDodajIme);
            this.groupBoxInsert.Controls.Add(this.label1);
            this.groupBoxInsert.Location = new System.Drawing.Point(12, 87);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(190, 351);
            this.groupBoxInsert.TabIndex = 15;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "Dodaj novo vrsto";
            // 
            // listBoxDodajKraj
            // 
            this.listBoxDodajKraj.FormattingEnabled = true;
            this.listBoxDodajKraj.Location = new System.Drawing.Point(25, 207);
            this.listBoxDodajKraj.Name = "listBoxDodajKraj";
            this.listBoxDodajKraj.Size = new System.Drawing.Size(140, 82);
            this.listBoxDodajKraj.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kraj";
            // 
            // listBoxDodajRazred
            // 
            this.listBoxDodajRazred.FormattingEnabled = true;
            this.listBoxDodajRazred.Location = new System.Drawing.Point(28, 96);
            this.listBoxDodajRazred.Name = "listBoxDodajRazred";
            this.listBoxDodajRazred.Size = new System.Drawing.Size(140, 82);
            this.listBoxDodajRazred.TabIndex = 23;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(57, 311);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Dodaj";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razred";
            // 
            // textBoxDodajIme
            // 
            this.textBoxDodajIme.Location = new System.Drawing.Point(25, 44);
            this.textBoxDodajIme.MaxLength = 60;
            this.textBoxDodajIme.Name = "textBoxDodajIme";
            this.textBoxDodajIme.Size = new System.Drawing.Size(143, 20);
            this.textBoxDodajIme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(315, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(110, 31);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "VRSTE";
            // 
            // Vrste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonDatabaseUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxVrste);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxInsert);
            this.Controls.Add(this.labelTitle);
            this.Name = "Vrste";
            this.Text = "Vrste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vrste_FormClosed);
            this.Load += new System.EventHandler(this.Vrste_Load);
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
        private System.Windows.Forms.ListBox listBoxVrste;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDodajIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxDodajRazred;
        private System.Windows.Forms.ListBox listBoxDodajKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxUpdateKraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxUpdateRazred;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUpdateIme;
    }
}