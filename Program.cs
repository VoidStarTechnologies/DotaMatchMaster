using DotaMatchMaster.Observer;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace DotaMatchMaster
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameManager.GetInstance().Start();

            Application.Run(GameManager.GetInstance().DotaMatchMasterForm);
        }
    }
}
