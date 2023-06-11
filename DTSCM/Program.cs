using DTSCM.Verification;
using SqlDataBase;
using System;
using System.Windows.Forms;

namespace DTSCM
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataBase.InitConnection();
            Application.Run(new ChosingActionForm());
        }
    }
}
