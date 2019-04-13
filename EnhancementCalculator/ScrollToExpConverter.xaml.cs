using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using EnhancementCalculator.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EnhancementCalculator
{
    /// <summary>
    /// Interaction logic for ScrollToExpConverter.xaml
    /// </summary>
    public partial class ScrollToExpConverter : UserControl
    {
        public List<int> LevelRanges { get; set; }
        public int SelectedStartLevel { get; set; }
        public int TenKkScrolls { get; set; }
        public int FiftyKkScrolls { get; set; }
        public int HundredKkScrolls { get; set; }
        public double GainedExpPercent
        {
            get { return (double)GetValue(GainedExpPercentProperty); }
            set { SetValue(GainedExpPercentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GainedExpPercent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GainedExpPercentProperty =
            DependencyProperty.Register("GainedExpPercent", typeof(double), typeof(ScrollToExpConverter), new PropertyMetadata(0.0));

        private IExpingCalculatorFactory m_CalculatorFactory;
        private IResultFormatter m_ResultFormatter = new ResultFormatter();

        public string ResultLevel
        {
            get { return (string)GetValue(ResultLevelProperty); }
            set { SetValue(ResultLevelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ResultLevel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ResultLevelProperty =
            DependencyProperty.Register("ResultLevel", typeof(string), typeof(ScrollToExpConverter), new PropertyMetadata(string.Empty));


        public string ExperienceOnLevelPercentage
        {
            get { return (string)GetValue(ExperienceOnLevelPercentageProperty); }
            set { SetValue(ExperienceOnLevelPercentageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ExperienceOnLevelPercentage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExperienceOnLevelPercentageProperty =
            DependencyProperty.Register("ExperienceOnLevelPercentage", typeof(string), typeof(ScrollToExpConverter), new PropertyMetadata(string.Empty));



        public string TotalExpToConvert
        {
            get { return (string)GetValue(TotalExpToConvertProperty); }
            set { SetValue(TotalExpToConvertProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalExpToConvert.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalExpToConvertProperty =
            DependencyProperty.Register("TotalExpToConvert", typeof(string), typeof(ScrollToExpConverter), new PropertyMetadata(string.Empty));



        public string MoneyTotal
        {
            get { return (string)GetValue(MoneyTotalProperty); }
            set { SetValue(MoneyTotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalMoney.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoneyTotalProperty =
            DependencyProperty.Register("MoneyTotal", typeof(string), typeof(ScrollToExpConverter), new PropertyMetadata(string.Empty));




        public ScrollToExpConverter()
        {
            LevelRanges = new List<int>();
            InitializeComponent();
            DataContext = this;
            FetchAllLevelRanges();
            m_CalculatorFactory = new CalculatorFactory();
        }
        public ScrollToExpConverter(IExpingCalculatorFactory calculatorFactory = null)
        {
            LevelRanges = new List<int>();
            InitializeComponent();
            DataContext = this;
            FetchAllLevelRanges();
            m_CalculatorFactory = calculatorFactory;
        }
        private void FetchAllLevelRanges()
        {
            LevelRanges.Clear();
            foreach (var level in ExperienceForLevelTable.LevelRanges)
            {
                LevelRanges.Add(level);
            }
            SelectedStartLevel = LevelRanges.FirstOrDefault();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var expingCalculator = m_CalculatorFactory.CreateExpingCalculator();
            var scrolls = new Scrolls(TenKkScrolls, FiftyKkScrolls, HundredKkScrolls);
            var result = expingCalculator.ConvertScrollsToLevel(
                SelectedStartLevel,
                GainedExpPercent,
                scrolls);
            ResultLevel =  result.ResultLevel.ToString();
            ExperienceOnLevelPercentage =  $"{result.GainedExpPercentageOnLevel.ToString()}%";
            TotalExpToConvert = m_ResultFormatter.Experience(scrolls.TotalExp);
            MoneyTotal = m_ResultFormatter.MoneyTotal(scrolls);
        }
    }
}
