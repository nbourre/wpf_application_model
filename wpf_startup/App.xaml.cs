using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace wpf_startup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            /// Méthode 1 : Accessible partout
            string[] commandLineArgs = Environment.GetCommandLineArgs();

            /// Méthode 2 : Accessible via cet événement
            string[] cmdLineArgs = e.Args;

            MessageBox.Show($"Nombre d'arguments : {cmdLineArgs.Length}");

            if (cmdLineArgs.Length > 0)
            {
                string message = string.Join(", ", cmdLineArgs);
                MessageBox.Show($"Les arguments sont : {message}");
            }

        }
    }
}
