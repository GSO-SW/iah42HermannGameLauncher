using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class SpielHinzufügenForm : Form
    {
        internal Spiel ReturnValue = null;

        public SpielHinzufügenForm()
        {
            InitializeComponent();
        }

        private void durchsuchenBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult res = ofd.ShowDialog();

            if (res == DialogResult.OK)
            {
                string[] result = ofd.FileName.Split('\\');
                StringBuilder path = new StringBuilder();

                foreach (string str in result)
                {
                    path.Append(str + "/");
                }
                path.Remove(path.Length - 1, 1);
                installationspfadTB.Text = path.ToString();

            }
        }

        private void speichernBTN_Click(object sender, EventArgs e)
        {
            Spiel s = null;
            try
            {
                string[] instDatA = installaionsdatumTB.Text.Split(':');

                int day = 0;
                int month = 0;
                int year = 0;

                try
                {
                    day = Convert.ToInt32(instDatA[0]);
                    month = Convert.ToInt32(instDatA[1]);
                    year = Convert.ToInt32(instDatA[2]);
                    DateTime instDat = new DateTime(year, month, day);
                    s = Controller.AddGame(TitelTB.Text, instDat, installationspfadTB.Text, kategorieTB.Text, publisherTB.Text, Convert.ToInt32(USK_NUD.Value));

                }
                catch (Exception)
                {
                    MessageBox.Show("Das Installationsdatum muss im Format TT:MM:JJJJ angegeben werden!");
                }

                ReturnValue = s;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void abbrechenBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
