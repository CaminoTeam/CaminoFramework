using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    // put game stats, player count, etc in here
    public class ClGameData
    {
        public List<ClPlayer> Players { get; set; }
        public int CurrentPlayer { get; set; }
        public string CurrentStatus { get; set; }

        private int _CurrentState;

        public int CurrentState
        {
            get { return _CurrentState; }
            set
            {
                // calls state changed
                bool hasChanged = false;
                if (_CurrentState != value)
                {
                    hasChanged = true;
                }
                _CurrentState = value;

                if (hasChanged)
                {
                    if (StateChanged != null)
                    {
                        StateChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        

        public event EventHandler StateChanged;

        public ClGameData()
        {
            Players = new List<ClPlayer>();
            CurrentStatus = "Waiting for player 1 to connect";
            CurrentPlayer = -1;
            CurrentState = 1;

        }
    }
}
