using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
