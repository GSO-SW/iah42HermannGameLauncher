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
        string SpieleTitel { get; set; }
        DateTime Installationsdatum { get; set; }
        DateTime ZuetztGespielt { get; set; }
        string Instalationspfad { get; set; }
        string Kategorie { get; set; }
        string Publisher { get; set; }
        int USKEinstufung { get; set; }

        public Spiel(string titel, DateTime instalationsdatum, string instalationsPfad, string kategorie, string publisher, int USK)
        {
            SpieleTitel = titel;
            Installationsdatum = instalationsdatum;
            ZuetztGespielt = new DateTime(2000, 01, 01);
            Instalationspfad = instalationsPfad;
            Kategorie = kategorie;
            Publisher = publisher;
            USKEinstufung = USK;
        }
    }
}
