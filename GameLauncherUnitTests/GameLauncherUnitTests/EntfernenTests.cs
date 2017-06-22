using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GameLauncherUnitTests
{
    [TestClass]
    public class EntfernenTests
    {

        [TestMethod]
        public void EntfernenOhneProbleme()
        {
            List<Spiel> gameL = new List<Spiel>();
            Spiel s = new Spiel("Darksouls", DateTime.Now, "C:/Games/Dark Souls III/Game/DarkSoulsIII.exe", "RPG", "From Software", 16);
            gameL.Add(s);

            gameL = Controller.RemoveGame(s, gameL);

            Assert.AreEqual(0, gameL.Count);
        }


    }
}
