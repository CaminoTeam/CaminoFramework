using CaminoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoClient
{
    public class MdGlobal
    {
        public static ClGameData GameData;

        public static int PlayerID { get; set; }
        public static string Nickname { get; set; }

        public static void Init()
        {
            GameData = new ClGameData();
            PlayerID = -1;
            Nickname = "Unnamed Player";
        }
    }
}
