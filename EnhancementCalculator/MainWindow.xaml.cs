using System.Reflection;
using System.Windows;

namespace EnhancementCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = $"Lineage 2 Classic Calculator v{Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
        }
    }
}
