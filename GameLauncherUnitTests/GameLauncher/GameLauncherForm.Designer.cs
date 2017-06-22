namespace GameLauncher
{
    partial class GameLauncherForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SpieleListBox = new System.Windows.Forms.ListBox();
            this.SpielHinzufügenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpieleListBox
            // 
            this.SpieleListBox.FormattingEnabled = true;
            this.SpieleListBox.ItemHeight = 20;
            this.SpieleListBox.Location = new System.Drawing.Point(12, 12);
            this.SpieleListBox.Name = "SpieleListBox";
            this.SpieleListBox.Size = new System.Drawing.Size(396, 604);
            this.SpieleListBox.TabIndex = 0;
            this.SpieleListBox.SelectedIndexChanged += new System.EventHandler(this.SpieleListBox_SelectedIndexChanged);
            // 
            // SpielHinzufügenButton
            // 
            this.SpielHinzufügenButton.Location = new System.Drawing.Point(12, 623);
            this.SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            this.SpielHinzufügenButton.Size = new System.Drawing.Size(147, 33);
            this.SpielHinzufügenButton.TabIndex = 1;
            this.SpielHinzufügenButton.Text = "SpielHinzufügen";
            this.SpielHinzufügenButton.UseVisualStyleBackColor = true;
            this.SpielHinzufügenButton.Click += new System.EventHandler(this.SpielHinzufügenButton_Click);
            // 
            // GameLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(427, 668);
            this.Controls.Add(this.SpielHinzufügenButton);
            this.Controls.Add(this.SpieleListBox);
            this.Name = "GameLauncherForm";
            this.Text = "Robin´s Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SpieleListBox;
        private System.Windows.Forms.Button SpielHinzufügenButton;
    }
}

