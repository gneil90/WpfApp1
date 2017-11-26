using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Reflection;
using System.Diagnostics;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            AssemblyInformationalVersionAttribute attribute =
               (AssemblyInformationalVersionAttribute)Assembly.GetExecutingAssembly()
               .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false).FirstOrDefault();

            string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;


            if (attribute != null)
            {
                Console.WriteLine("Version " + attribute.InformationalVersion);
                Console.WriteLine("Assembly version" + assemblyVersion);
                Console.WriteLine("File version" + fileVersion);
            } 
            else
            {
                Console.WriteLine("Unknown Version");
            }
        }
    }
}
