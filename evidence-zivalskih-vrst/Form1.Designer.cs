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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxKraji = new System.Windows.Forms.ListBox();
            this.buttonKrajForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRazredi = new System.Windows.Forms.ListBox();
            this.groupBoxKraji = new System.Windows.Forms.GroupBox();
            this.groupBoxRazredi = new System.Windows.Forms.GroupBox();
            this.buttonRazredForm = new System.Windows.Forms.Button();
            this.buttonVrsteForm = new System.Windows.Forms.Button();
            this.groupBoxVrste = new System.Windows.Forms.GroupBox();
            this.listBoxVrste = new System.Windows.Forms.ListBox();
            this.labelByKraj = new System.Windows.Forms.Label();
            this.labelByVrste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFont = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxKraji.SuspendLayout();
            this.groupBoxRazredi.SuspendLayout();
            this.groupBoxVrste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKraji
            // 
            this.listBoxKraji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBoxKraji.FormattingEnabled = true;
            this.listBoxKraji.Location = new System.Drawing.Point(6, 29);
            this.listBoxKraji.Name = "listBoxKraji";
            this.listBoxKraji.Size = new System.Drawing.Size(207, 290);
            this.listBoxKraji.TabIndex = 1;
            this.listBoxKraji.SelectedIndexChanged += new System.EventHandler(this.listBoxKraji_SelectedIndexChanged);
            // 
            // buttonKrajForm
            // 
            this.buttonKrajForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonKrajForm.Location = new System.Drawing.Point(28, 349);
            this.buttonKrajForm.Name = "buttonKrajForm";
            this.buttonKrajForm.Size = new System.Drawing.Size(163, 23);
            this.buttonKrajForm.TabIndex = 2;
            this.buttonKrajForm.Text = "Upravljaj kraje";
            this.buttonKrajForm.UseVisualStyleBackColor = true;
            this.buttonKrajForm.Click += new System.EventHandler(this.buttonKrajForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "V tem kraju je\r\n toliko različnih vrst:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teh vrst je v\r\n toliko različnih krajih:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRazredi
            // 
            this.listBoxRazredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBoxRazredi.FormattingEnabled = true;
            this.listBoxRazredi.Location = new System.Drawing.Point(6, 29);
            this.listBoxRazredi.Name = "listBoxRazredi";
            this.listBoxRazredi.Size = new System.Drawing.Size(132, 290);
            this.listBoxRazredi.TabIndex = 12;
            // 
            // groupBoxKraji
            // 
            this.groupBoxKraji.Controls.Add(this.listBoxKraji);
            this.groupBoxKraji.Controls.Add(this.buttonKrajForm);
            this.groupBoxKraji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxKraji.Location = new System.Drawing.Point(18, 81);
            this.groupBoxKraji.Name = "groupBoxKraji";
            this.groupBoxKraji.Size = new System.Drawing.Size(219, 388);
            this.groupBoxKraji.TabIndex = 13;
            this.groupBoxKraji.TabStop = false;
            this.groupBoxKraji.Text = "Kraji";
            // 
            // groupBoxRazredi
            // 
            this.groupBoxRazredi.Controls.Add(this.buttonRazredForm);
            this.groupBoxRazredi.Controls.Add(this.listBoxRazredi);
            this.groupBoxRazredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxRazredi.Location = new System.Drawing.Point(243, 81);
            this.groupBoxRazredi.Name = "groupBoxRazredi";
            this.groupBoxRazredi.Size = new System.Drawing.Size(144, 388);
            this.groupBoxRazredi.TabIndex = 14;
            this.groupBoxRazredi.TabStop = false;
            this.groupBoxRazredi.Text = "Razredi";
            // 
            // buttonRazredForm
            // 
            this.buttonRazredForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRazredForm.Location = new System.Drawing.Point(16, 349);
            this.buttonRazredForm.Name = "buttonRazredForm";
            this.buttonRazredForm.Size = new System.Drawing.Size(114, 23);
            this.buttonRazredForm.TabIndex = 15;
            this.buttonRazredForm.Text = "Upravljaj razrede";
            this.buttonRazredForm.UseVisualStyleBackColor = true;
            this.buttonRazredForm.Click += new System.EventHandler(this.buttonRazredForm_Click);
            // 
            // buttonVrsteForm
            // 
            this.buttonVrsteForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVrsteForm.Location = new System.Drawing.Point(20, 349);
            this.buttonVrsteForm.Name = "buttonVrsteForm";
            this.buttonVrsteForm.Size = new System.Drawing.Size(114, 23);
            this.buttonVrsteForm.TabIndex = 16;
            this.buttonVrsteForm.Text = "Upravljaj vrste";
            this.buttonVrsteForm.UseVisualStyleBackColor = true;
            this.buttonVrsteForm.Click += new System.EventHandler(this.buttonVrsteForm_Click);
            // 
            // groupBoxVrste
            // 
            this.groupBoxVrste.Controls.Add(this.listBoxVrste);
            this.groupBoxVrste.Controls.Add(this.buttonVrsteForm);
            this.groupBoxVrste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxVrste.Location = new System.Drawing.Point(393, 81);
            this.groupBoxVrste.Name = "groupBoxVrste";
            this.groupBoxVrste.Size = new System.Drawing.Size(150, 388);
            this.groupBoxVrste.TabIndex = 17;
            this.groupBoxVrste.TabStop = false;
            this.groupBoxVrste.Text = "Vrste";
            // 
            // listBoxVrste
            // 
            this.listBoxVrste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxVrste.FormattingEnabled = true;
            this.listBoxVrste.Location = new System.Drawing.Point(6, 29);
            this.listBoxVrste.Name = "listBoxVrste";
            this.listBoxVrste.Size = new System.Drawing.Size(138, 290);
            this.listBoxVrste.TabIndex = 12;
            this.listBoxVrste.SelectedIndexChanged += new System.EventHandler(this.listBoxVrste_SelectedIndexChanged);
            // 
            // labelByKraj
            // 
            this.labelByKraj.AutoSize = true;
            this.labelByKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelByKraj.Location = new System.Drawing.Point(602, 156);
            this.labelByKraj.Name = "labelByKraj";
            this.labelByKraj.Size = new System.Drawing.Size(17, 18);
            this.labelByKraj.TabIndex = 18;
            this.labelByKraj.Text = "0";
            // 
            // labelByVrste
            // 
            this.labelByVrste.AutoSize = true;
            this.labelByVrste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelByVrste.Location = new System.Drawing.Point(720, 156);
            this.labelByVrste.Name = "labelByVrste";
            this.labelByVrste.Size = new System.Drawing.Size(17, 18);
            this.labelByVrste.TabIndex = 19;
            this.labelByVrste.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(585, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 90);
            this.label3.TabIndex = 20;
            this.label3.Text = "Za pregled koliko vrst\r\nje v katerem kraju in\r\nkater kraj ima koliko\r\nvrsti, izbe" +
    "rite vrstice\r\nv Kraji in Vrste seznamih.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(549, 300);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Število";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(241, 205);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(142, 489);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(33, 13);
            this.labelFont.TabIndex = 22;
            this.labelFont.Text = "l_font";
            this.labelFont.Visible = false;
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(181, 489);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(72, 13);
            this.labelBackground.TabIndex = 23;
            this.labelBackground.Text = "l_background";
            this.labelBackground.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(28, 484);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(94, 23);
            this.buttonSettings.TabIndex = 24;
            this.buttonSettings.Text = "Spremeni barve";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(111, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(588, 31);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "EVIDENCE ŽIVALSKIH VRST V SLOVENIJI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::evidence_zivalskih_vrst.Properties.Resources.mainKoala;
            this.pictureBox1.Location = new System.Drawing.Point(700, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(700, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelByVrste);
            this.Controls.Add(this.labelByKraj);
            this.Controls.Add(this.groupBoxVrste);
            this.Controls.Add(this.groupBoxRazredi);
            this.Controls.Add(this.groupBoxKraji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Glavni zavihek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKraji.ResumeLayout(false);
            this.groupBoxRazredi.ResumeLayout(false);
            this.groupBoxVrste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxVrste;
        private System.Windows.Forms.ListBox listBoxVrste;
        private System.Windows.Forms.Label labelByKraj;
        private System.Windows.Forms.Label labelByVrste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

