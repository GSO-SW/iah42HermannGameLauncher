namespace GameLauncher
{
    partial class SpielHinzufügenForm
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
            this.TitelLable = new System.Windows.Forms.Label();
            this.InstallationsdatumLable = new System.Windows.Forms.Label();
            this.InstallationspfadLable = new System.Windows.Forms.Label();
            this.KategorieLable = new System.Windows.Forms.Label();
            this.PublisherLable = new System.Windows.Forms.Label();
            this.USKEinstufungLable = new System.Windows.Forms.Label();
            this.TitelTB = new System.Windows.Forms.TextBox();
            this.durchsuchenBTN = new System.Windows.Forms.Button();
            this.installationspfadTB = new System.Windows.Forms.TextBox();
            this.kategorieTB = new System.Windows.Forms.TextBox();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.USK_NUD = new System.Windows.Forms.NumericUpDown();
            this.speichernBTN = new System.Windows.Forms.Button();
            this.abbrechenBTN = new System.Windows.Forms.Button();
            this.installaionsdatumTB = new System.Windows.Forms.TextBox();
            this.TitelLB = new System.Windows.Forms.Label();
            this.installationsdatumLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.USK_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // TitelLable
            // 
            this.TitelLable.Location = new System.Drawing.Point(0, 0);
            this.TitelLable.Name = "TitelLable";
            this.TitelLable.Size = new System.Drawing.Size(100, 23);
            this.TitelLable.TabIndex = 17;
            // 
            // InstallationsdatumLable
            // 
            this.InstallationsdatumLable.Location = new System.Drawing.Point(0, 0);
            this.InstallationsdatumLable.Name = "InstallationsdatumLable";
            this.InstallationsdatumLable.Size = new System.Drawing.Size(100, 23);
            this.InstallationsdatumLable.TabIndex = 16;
            // 
            // InstallationspfadLable
            // 
            this.InstallationspfadLable.AutoSize = true;
            this.InstallationspfadLable.Location = new System.Drawing.Point(12, 152);
            this.InstallationspfadLable.Name = "InstallationspfadLable";
            this.InstallationspfadLable.Size = new System.Drawing.Size(126, 20);
            this.InstallationspfadLable.TabIndex = 2;
            this.InstallationspfadLable.Text = "Installationspfad";
            // 
            // KategorieLable
            // 
            this.KategorieLable.AutoSize = true;
            this.KategorieLable.Location = new System.Drawing.Point(278, 23);
            this.KategorieLable.Name = "KategorieLable";
            this.KategorieLable.Size = new System.Drawing.Size(77, 20);
            this.KategorieLable.TabIndex = 3;
            this.KategorieLable.Text = "Kategorie";
            // 
            // PublisherLable
            // 
            this.PublisherLable.AutoSize = true;
            this.PublisherLable.Location = new System.Drawing.Point(278, 83);
            this.PublisherLable.Name = "PublisherLable";
            this.PublisherLable.Size = new System.Drawing.Size(74, 20);
            this.PublisherLable.TabIndex = 4;
            this.PublisherLable.Text = "Publisher";
            // 
            // USKEinstufungLable
            // 
            this.USKEinstufungLable.AutoSize = true;
            this.USKEinstufungLable.Location = new System.Drawing.Point(12, 83);
            this.USKEinstufungLable.Name = "USKEinstufungLable";
            this.USKEinstufungLable.Size = new System.Drawing.Size(124, 20);
            this.USKEinstufungLable.TabIndex = 5;
            this.USKEinstufungLable.Text = "USK-Einstufung";
            // 
            // TitelTB
            // 
            this.TitelTB.Location = new System.Drawing.Point(12, 46);
            this.TitelTB.Name = "TitelTB";
            this.TitelTB.Size = new System.Drawing.Size(168, 26);
            this.TitelTB.TabIndex = 6;
            // 
            // durchsuchenBTN
            // 
            this.durchsuchenBTN.Location = new System.Drawing.Point(340, 168);
            this.durchsuchenBTN.Name = "durchsuchenBTN";
            this.durchsuchenBTN.Size = new System.Drawing.Size(118, 40);
            this.durchsuchenBTN.TabIndex = 8;
            this.durchsuchenBTN.Text = "durchsuchen";
            this.durchsuchenBTN.UseVisualStyleBackColor = true;
            this.durchsuchenBTN.Click += new System.EventHandler(this.durchsuchenBTN_Click);
            // 
            // installationspfadTB
            // 
            this.installationspfadTB.Location = new System.Drawing.Point(14, 175);
            this.installationspfadTB.Name = "installationspfadTB";
            this.installationspfadTB.Size = new System.Drawing.Size(320, 26);
            this.installationspfadTB.TabIndex = 9;
            // 
            // kategorieTB
            // 
            this.kategorieTB.Location = new System.Drawing.Point(278, 46);
            this.kategorieTB.Name = "kategorieTB";
            this.kategorieTB.Size = new System.Drawing.Size(168, 26);
            this.kategorieTB.TabIndex = 10;
            // 
            // publisherTB
            // 
            this.publisherTB.Location = new System.Drawing.Point(278, 106);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(168, 26);
            this.publisherTB.TabIndex = 11;
            // 
            // USK_NUD
            // 
            this.USK_NUD.Location = new System.Drawing.Point(12, 106);
            this.USK_NUD.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.USK_NUD.Name = "USK_NUD";
            this.USK_NUD.Size = new System.Drawing.Size(168, 26);
            this.USK_NUD.TabIndex = 12;
            // 
            // speichernBTN
            // 
            this.speichernBTN.Location = new System.Drawing.Point(16, 291);
            this.speichernBTN.Name = "speichernBTN";
            this.speichernBTN.Size = new System.Drawing.Size(214, 39);
            this.speichernBTN.TabIndex = 13;
            this.speichernBTN.Text = "Speichern";
            this.speichernBTN.UseVisualStyleBackColor = true;
            this.speichernBTN.Click += new System.EventHandler(this.speichernBTN_Click);
            // 
            // abbrechenBTN
            // 
            this.abbrechenBTN.Location = new System.Drawing.Point(240, 291);
            this.abbrechenBTN.Name = "abbrechenBTN";
            this.abbrechenBTN.Size = new System.Drawing.Size(214, 39);
            this.abbrechenBTN.TabIndex = 14;
            this.abbrechenBTN.Text = "Abbrechen";
            this.abbrechenBTN.UseVisualStyleBackColor = true;
            this.abbrechenBTN.Click += new System.EventHandler(this.abbrechenBTN_Click);
            // 
            // installaionsdatumTB
            // 
            this.installaionsdatumTB.Location = new System.Drawing.Point(16, 250);
            this.installaionsdatumTB.Name = "installaionsdatumTB";
            this.installaionsdatumTB.Size = new System.Drawing.Size(168, 26);
            this.installaionsdatumTB.TabIndex = 15;
            // 
            // TitelLB
            // 
            this.TitelLB.AutoSize = true;
            this.TitelLB.Location = new System.Drawing.Point(12, 23);
            this.TitelLB.Name = "TitelLB";
            this.TitelLB.Size = new System.Drawing.Size(38, 20);
            this.TitelLB.TabIndex = 18;
            this.TitelLB.Text = "Titel";
            // 
            // installationsdatumLB
            // 
            this.installationsdatumLB.AutoSize = true;
            this.installationsdatumLB.Location = new System.Drawing.Point(12, 227);
            this.installationsdatumLB.Name = "installationsdatumLB";
            this.installationsdatumLB.Size = new System.Drawing.Size(227, 20);
            this.installationsdatumLB.TabIndex = 19;
            this.installationsdatumLB.Text = "Installationsdatum TT:MM:JJJJ";
            // 
            // SpielHinzufügenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 348);
            this.Controls.Add(this.installationsdatumLB);
            this.Controls.Add(this.TitelLB);
            this.Controls.Add(this.installaionsdatumTB);
            this.Controls.Add(this.abbrechenBTN);
            this.Controls.Add(this.speichernBTN);
            this.Controls.Add(this.USK_NUD);
            this.Controls.Add(this.publisherTB);
            this.Controls.Add(this.kategorieTB);
            this.Controls.Add(this.installationspfadTB);
            this.Controls.Add(this.durchsuchenBTN);
            this.Controls.Add(this.TitelTB);
            this.Controls.Add(this.USKEinstufungLable);
            this.Controls.Add(this.PublisherLable);
            this.Controls.Add(this.KategorieLable);
            this.Controls.Add(this.InstallationspfadLable);
            this.Controls.Add(this.InstallationsdatumLable);
            this.Controls.Add(this.TitelLable);
            this.Name = "SpielHinzufügenForm";
            this.Text = "SpielHinzufügenForm";
            ((System.ComponentModel.ISupportInitialize)(this.USK_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitelLable;
        private System.Windows.Forms.Label InstallationsdatumLable;
        private System.Windows.Forms.Label InstallationspfadLable;
        private System.Windows.Forms.Label KategorieLable;
        private System.Windows.Forms.Label PublisherLable;
        private System.Windows.Forms.Label USKEinstufungLable;
        private System.Windows.Forms.TextBox TitelTB;
        private System.Windows.Forms.Button durchsuchenBTN;
        private System.Windows.Forms.TextBox installationspfadTB;
        private System.Windows.Forms.TextBox kategorieTB;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.NumericUpDown USK_NUD;
        private System.Windows.Forms.Button speichernBTN;
        private System.Windows.Forms.Button abbrechenBTN;
        private System.Windows.Forms.TextBox installaionsdatumTB;
        private System.Windows.Forms.Label TitelLB;
        private System.Windows.Forms.Label installationsdatumLB;
    }
}