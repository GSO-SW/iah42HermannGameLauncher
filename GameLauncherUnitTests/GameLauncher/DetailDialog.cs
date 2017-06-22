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
    public partial class DetailDialog : Form
    {
        Spiel SelectedGame = null;
        internal DetailDialog(Spiel s)
        {
            InitializeComponent();
            SelectedGame = s;
        }

        private void SpielStartenBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Controller.StartGame(SelectedGame);
            }
            catch (GameAlreadyRunExeption exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void DetailDialog_Load(object sender, EventArgs e)
        {
            TitelTB.Text = SelectedGame.GetSpieleTitel;
            kategorieTB.Text = SelectedGame.GetKategorie;
            USK_NUD.Value = SelectedGame.GetUSKEinstufung;
            publisherTB.Text = SelectedGame.GetPublisher;
            installationspfadTB.Text = SelectedGame.GetInstalationspfad;
            installationsdatumTB.Text = SelectedGame.GetInstalationsdatum.ToString();
            zuletztGespieltTB.Text = SelectedGame.GetZuletztGespielt.ToString();
        }
    }
}
