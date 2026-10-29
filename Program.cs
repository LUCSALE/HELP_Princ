using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_Princ
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            InfoApp.versao = "1.00.180";
            InfoApp.sistema = "HELP_Princ";
            InfoApp.UsuarioAD = Environment.UserName;
            InfoApp.NomeComputador = Environment.MachineName;   

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplashScreen());
        }
    }
}
