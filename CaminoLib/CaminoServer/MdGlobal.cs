using CaminoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoServer
{
    public class MdGlobal
    {


        private static ClGameData _GameData;

        public static ClGameData GameData
        {
            get { return _GameData; }
            set
            {
                Console.WriteLine("Server GameData instance changed with state " + value.CurrentState.ToString());
                bool hasChanged = false;
                if (value != _GameData)
                {
                    hasChanged = true;
                }
                _GameData = value;
                if (hasChanged)
                {
                    _GameData.StateChanged += new EventHandler(StateChanged);
                }
            }
        }

        public static int MAX_PLAYERS = 2;

        private static void StateChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Server state changed to " + GameData.CurrentState.ToString());

            HServerHub.UpdateGameData();
            if (MdUI.MainForm != null)
            {

                if (MdUI.MainForm.InvokeRequired)
                {
                    MdUI.MainForm.Invoke(new Action(() => MdUI.MainForm.StateMachineUpdate(GameData.CurrentState)));
                }
                else
                {

                    MdUI.MainForm.StateMachineUpdate(GameData.CurrentState);
                }
            }
        }


        public static void Init()
        {
            GameData = new ClGameData();

        }
    }
}
