using System;
using System.Windows.Forms;

namespace CatalogoGestion2025
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el SplashScreen antes de abrir GestionCatalogo
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Application.DoEvents(); // Permite que el formulario se renderice correctamente
            System.Threading.Thread.Sleep(10000); // Espera 2 segundos
            splash.Close();

            // Iniciar la aplicación principal
            Application.Run(new GestionCatalogo());
        }
    }
}
