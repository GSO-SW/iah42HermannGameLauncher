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
    public partial class GameLauncherForm : Form
    {
        internal List<Spiel> GetSetGameList
        { get
            {
                List<Spiel> games = new List<Spiel>();
                foreach (Spiel s in SpieleListBox.Items)
                {
                    games.Add(s);
                }
                return games;
            }
        }

        public GameLauncherForm()
        {
            InitializeComponent();
            SpieleListBox.DisplayMember = "GetSpieleTitel";
        }

        private void SpielHinzufügenButton_Click(object sender, EventArgs e)
        {
            SpielHinzufügenForm newGameDialog = new GameLauncher.SpielHinzufügenForm();

            this.Hide();

            newGameDialog.ShowDialog();
            Spiel s = newGameDialog.ReturnValue;
            
            this.Show();

            SpieleListBox.Items.Add(s);
        }

        private void SpieleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();

            DetailDialog detDialog = new DetailDialog(SpieleListBox.SelectedItem as Spiel);
            detDialog.ShowDialog();

            this.Show();
        }
    }
}
