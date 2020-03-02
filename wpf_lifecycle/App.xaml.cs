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
