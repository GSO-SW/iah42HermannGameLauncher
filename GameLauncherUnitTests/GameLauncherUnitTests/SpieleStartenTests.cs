using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher;
using System.Linq;
using System.Diagnostics;

namespace GameLauncherUnitTests
{
    [TestClass]
    public class SpieleStartenTests
    {
        [TestMethod]
        public void StartetDasSpiel()
        {
            Spiel s = new Spiel("Firefox", DateTime.Now, "C:/Program Files (x86)/Mozilla Firefox/firefox.exe", "mail", "mozila", 0);
            string[] pfadTeile = s.GetInstalationspfad.Split('/');
            string processname = pfadTeile.Last().Split('.').First();
            Process[] proA = Process.GetProcessesByName(processname);
            foreach (Process pro in proA)
            {
                pro.Kill();
                System.Threading.Thread.Sleep(1000);
            }

            Controller.StartGame(s);

            Assert.AreEqual(1, Process.GetProcessesByName("firefox").Length);

        }

        [TestMethod]
        [ExpectedException(typeof(GameAlreadyRunExeption))]
        public void StartetDasSpielNichtWennEsBereitsGeöffnetIst()
        {
            Spiel s = new Spiel("Lol", DateTime.Now, "C:/Riot Games/League of Legends/LeagueClient.exe", "lol", "LOL", 0);

            Process.Start(s.GetInstalationspfad);

            Controller.StartGame(s);
        }

    }
}
