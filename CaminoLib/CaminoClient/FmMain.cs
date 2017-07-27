using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaminoClient
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            SetLPlayerName(MdGlobal.Nickname);
        }

        #region state machine

        // all operations in here should be preceeded with a thread check, everything in here should be thread safe
        public void StateMachineUpdate(int state)
        {
            Console.WriteLine("Client state machine switch to state " + state.ToString());
            if (state == 1)
            {
                SetLStatus("Connecting to server...");
            }
            else if (state == 2)
            {
                SetLStatus("Player 1: " + MdGlobal.GameData.Players[0].Nickname + " has joined, awaiting player 2");

            }
            else if (state == 3)
            {
                SetLStatus("Game starting");

            }
            else if (state == 4)
            {

            }
            else if (state == 5)
            {

            }
        }


        #endregion state machine


        // provides thread safe ui updates
        #region uiupdates

        public void SetLPlayerName(string input)
        {
            if (LPlayerName.InvokeRequired)
            {
                this.Invoke(new Action(() => LPlayerName.Text = input));
            }
            else
            {
                LPlayerName.Text = input;
            }
        }

        public void SetLStatus(string input)
        {
            if (LStatus.InvokeRequired)
            {
                this.Invoke(new Action(() => LStatus.Text = input));
            }
            else
            {
                LStatus.Text = input;
            }
        }

        #endregion uiupdates

        #region ui event handlers

        private void BtJoinGame_Click(object sender, EventArgs e)
        {

            MdCClient.SendJoinGameRequest();
            BtJoinGame.Visible = false;
        }

        #endregion ui event handlers

    }
}
