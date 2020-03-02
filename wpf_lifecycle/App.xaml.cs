using System;
using System.Reflection;
using System.Windows;

namespace wpf_lifecycle
{
    /// <summary>
    /// Note : Pour afficher la console dans une application WPF, il faut changer
    /// les propriétés du projet dans le type de sortie au lieu d'application
    /// Windows, sélectionner "Application console"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");

            /// L'application quitte immédiatement après que la dernière fenêtre ferme
            ShutdownMode = ShutdownMode.OnLastWindowClose;

            /// L'application ne quitte que lorsque lorsqu'il y a appelle de
            /// Application.Shutdown();
            ShutdownMode = ShutdownMode.OnExplicitShutdown;

            /// L'application quitte lorsque la fenêtre appelée dans le
            /// StartupUri ferme (habituellement dans App.xaml)
            ShutdownMode = ShutdownMode.OnMainWindowClose;

            base.OnStartup(e);
        }

        protected override void OnActivated(EventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");
            base.OnActivated(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");
            base.OnDeactivated(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");
            base.OnExit(e);
        }
    }
}
