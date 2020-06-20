using SistemaEscolar.Views;
using System;
using System.Windows.Forms;

namespace SistemaEscolar
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSistemaEscolar());
        }
    }
}
