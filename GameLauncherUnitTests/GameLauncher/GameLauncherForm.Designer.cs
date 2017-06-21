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
            this.SuspendLayout();
            // 
            // SpieleListBox
            // 
            this.SpieleListBox.FormattingEnabled = true;
            this.SpieleListBox.ItemHeight = 20;
            this.SpieleListBox.Location = new System.Drawing.Point(37, 133);
            this.SpieleListBox.Name = "SpieleListBox";
            this.SpieleListBox.Size = new System.Drawing.Size(109, 64);
            this.SpieleListBox.TabIndex = 0;
            // 
            // GameLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.SpieleListBox);
            this.Name = "GameLauncherForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SpieleListBox;
    }
}

