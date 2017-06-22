using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLauncher
{
    internal class Spiel
    {
        string SpieleTitel;
        DateTime Installationsdatum { get; set; }
        DateTime ZuetztGespielt { get; set; }
        string Instalationspfad;
        string Kategorie { get; set; }
        string Publisher { get; set; }
        int USKEinstufung { get; set; }

        public Spiel(string titel, DateTime instalationsdatum, string instalationsPfad, string kategorie, string publisher, int USK)
        {
            SpieleTitel = titel;
            Installationsdatum = instalationsdatum;
            ZuetztGespielt = new DateTime(2000, 01, 01);


            if (File.Exists(instalationsPfad))
            {
                Instalationspfad = instalationsPfad; 
            }
            else
            {
                throw new FileNotFoundException();
            }

            Kategorie = kategorie;
            Publisher = publisher;
            USKEinstufung = USK;
        }

        public string GetSpieleTitel
        {
            get { return SpieleTitel; }
        }

        public string GetInstalationspfad
        {
            get { return Instalationspfad; }
        }

        public DateTime GetInstalationsdatum
        {
            get { return Installationsdatum; }
        }

        public DateTime GetZuletztGespielt
        {
            get { return ZuetztGespielt; }
        }

        public string GetKategorie
        {
            get { return Kategorie; }
        }
        public string GetPublisher
        {
            get { return Publisher; }
        }

        public int GetUSKEinstufung
        {
            get { return USKEinstufung; }
        }

    }
}
