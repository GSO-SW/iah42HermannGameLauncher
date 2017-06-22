using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher;
using System.Collections.Generic;
using System.IO;


namespace GameLauncherUnitTests
{
    [TestClass]
    public class SpieleHinzufügenTests
    {
        [TestMethod]
        public void HinzufügenOhneProbleme()
        {
            List<Spiel> gameL = new List<Spiel>();

            gameL = Controller.AddGame("Darksouls", DateTime.Now, "C:/Games/Dark Souls III/Game/DarkSoulsIII.exe", "RPG", "From Software", 16, gameL);
            
            Assert.AreEqual(1, gameL.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void HinzufügenUnbekanterPfad()
        {
            List<Spiel> gameL = new List<Spiel>();

            gameL = Controller.AddGame("Darksouls", DateTime.Now, @"C:\Games\Dark Souls III\Game\DaSoulsIII.exe", "RPG", "From Software", 16, gameL);

            Assert.AreEqual(0, gameL.Count);
        }


        



    }
}
