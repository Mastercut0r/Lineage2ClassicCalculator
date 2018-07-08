using System.Windows;
using System.Windows.Controls;

namespace EnhancementCalculator.UserControls
{
    /// <summary>
    /// Interaction logic for ArenaRbSelector.xaml
    /// </summary>
    public partial class ArenaRbSelector : UserControl
    {
        public ArenaRbSelector()
        {
            InitializeComponent();
            DataContext = this;
        }


        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(ArenaRbSelector), new PropertyMetadata(false));



        public string SelectedRbCount
        {
            get { return (string)GetValue(SelectedRbCountProperty); }
            set { SetValue(SelectedRbCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedRbCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedRbCountProperty =
            DependencyProperty.Register("SelectedRbCount", typeof(string), typeof(ArenaRbSelector), new PropertyMetadata(1));



    }
}
