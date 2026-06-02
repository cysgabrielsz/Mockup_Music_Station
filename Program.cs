using System;
using System.Windows.Forms;

namespace Mockup_Music_Station
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin entrando = new FormLogin();

            Application.Run(entrando);

            if (entrando.saida)
            {
                forminicial tela = new forminicial();

                tela.NivelAcesso = entrando.NivelAcesso;

                entrando.Dispose();

                Application.Run(tela);
            }
        }
    }
}