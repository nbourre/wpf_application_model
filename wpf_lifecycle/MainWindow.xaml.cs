using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace wpf_lifecycle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnActivated(EventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");

            base.OnActivated(e);
        }

        protected override void OnContentRendered(EventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");

            base.OnContentRendered(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");
            
            base.OnClosing(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");

            base.OnDeactivated(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");

            base.OnClosed(e);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Exécution de {m.ReflectedType.Name}.{m.Name}");
        }
    }
}
