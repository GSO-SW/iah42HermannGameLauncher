using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace GameLauncher
{
    internal class Controller
    {


        internal static List<Spiel> AddGame(string titel, DateTime instaldate, string pfad, string kat, string pub, int USK, List<Spiel> gameList)
        {
            bool titelOk = StringArgumentsNotEmpty(titel);

            bool pfadOk = PfadVorhanden(pfad);

            bool katOk = StringArgumentsNotEmpty(kat);

            bool pubOk = StringArgumentsNotEmpty(pub);

            bool uskOk = USKPassend(USK);

            if (titelOk && pfadOk && katOk && pfadOk && uskOk)
            {
                Spiel s = new Spiel(titel, instaldate, pfad, kat, pub, USK);
                gameList.Add(s);
                return gameList;
            }
            else
            {
                throw new Exception();
            }

        }

        internal static List<Spiel> RemoveGame(Spiel s, List<Spiel> gameL)
        {
            if (s != null)
            {
                gameL.Remove(s);
                return gameL;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        internal static void StartGame(Spiel s)
        {
            //Bsp: @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe"
            string[] pfadTeile = s.GetInstalationspfad.Split('/');
            //Bsp: "firefox.exe" möchte aber nur firefox
            string processname = pfadTeile.Last().Split('.').First();

            if (Process.GetProcessesByName(processname).Length > 0 )
            {
                throw new GameAlreadyRunExeption();
            }

            Process.Start(s.GetInstalationspfad);

        }



        #region Validierngen

        internal static bool StringArgumentsNotEmpty(string titel)
        {
            if (!(titel != string.Empty))
            {
                throw new ArgumentNullException();
            }
            else
            {
                return true;
            }
        }

        internal static bool PfadVorhanden(string pfad)
        {
            //Falls es den Pfad nicht gibt
            if (!(File.Exists(pfad)))
            {
                throw new FileNotFoundException("Es gibt den angegebenen Pfad nicht.");
            }
            else
            {
                return true;
            }
        }
        
        internal static bool USKPassend(int uskValue)
        {
            //Falls es den Pfad nicht gibt
            if (!(uskValue == 0 || uskValue == 12 || uskValue == 16 || uskValue == 18))
            {
                throw new IndexOutOfRangeException("Der Wert darf nur 0,12,16 oder 18 sein.");
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}