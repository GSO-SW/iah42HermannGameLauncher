using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    class GameAlreadyRunExeption : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Das Spiel läuft bereits";
            }
        }
    }
}
