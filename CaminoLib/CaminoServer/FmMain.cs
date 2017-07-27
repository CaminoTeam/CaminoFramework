using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaminoServer
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        #region state machine

        public void StateMachineUpdate(int state)
        {
            Console.WriteLine("Server state machine running state " + state.ToString());

            if (state == 1)
            {
                MdGlobal.GameData.CurrentStatus = "Connecting to server...";
            }
            else if (state == 2)
            {
                MdGlobal.GameData.CurrentStatus = "Player 1: " + MdGlobal.GameData.Players[0].Nickname + " has joined, awaiting player 2";

            }
            else if (state == 3) // assuming a 2 player game, the cycle begins here
            {
                MdGlobal.GameData.CurrentStatus = "Game starting";

            }
            else if (state == 4)
            {
                MdGlobal.GameData.CurrentStatus = "";

            }
            else if (state == 5)
            {
                MdGlobal.GameData.CurrentStatus = "";

            }

            SetLStatus(MdGlobal.GameData.CurrentStatus);

        }

        #endregion state machine


        #region ui helpers

        public void SetLStatus(string input)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.LStatus.Text = input));
            }
            else
            {

                LStatus.Text = input;
            }
        }
        #endregion ui helpers
    }
}
