using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaminoClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MdCClient.Url = args[0];
                MdCClient.Init();
                MdGlobal.Init();
                MdGlobal.Nickname = args[1];
                MdUI.Init();
                Application.Run(MdUI.MainForm);
            }
        }
    }
}
