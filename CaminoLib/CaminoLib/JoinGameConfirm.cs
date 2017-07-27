using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    public class JoinGameConfirm
    {
        public ClPlayer Player { get; set; }
        public bool Confirm { get; set; }
        public int PlayerID { get; set; }

        public JoinGameConfirm()
        {
            Player = new ClPlayer();
            Confirm = false;
            PlayerID = -1;
        }

        public JoinGameConfirm(ClPlayer player, bool confirm, int id) : this()
        {
            this.Player = player;
            this.Confirm = confirm;
            this.PlayerID = id;
        }
    }
}
