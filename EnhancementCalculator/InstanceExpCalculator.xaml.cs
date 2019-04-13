using EnhancementCalculator.Constants;
using EnhancementCalculator.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EnhancementCalculator
{
    /// <summary>
    /// Interaction logic for InstanceExpCalculator.xaml
    /// </summary>
    public partial class InstanceExpCalculator : UserControl
    {
        public bool ArenaEnabled { get; set; }
        public bool BaiumEnabled { get; set; }
        public bool ZakenEnabled { get; set; }
        public bool AntharasEnabled { get; set; }
        public bool DailyQuestsEnabled { get; set; }

        public List<int> LevelRanges { get; set; }
        public ObservableCollection<int> TargetLevelRanges { get; set; }
        private int m_SelectedStartLevel;
        public int SelectedStartLevel
        {
            get { return m_SelectedStartLevel; }
            set
            {
                m_SelectedStartLevel = value;
                FetchPossibleTargetLevelRanges();
            }
        }
        public int SelectedTargetLevel
        {
            get { return (int)GetValue(SelectedTargetLevelProperty); }
            set { SetValue(SelectedTargetLevelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedTargetLevel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedTargetLevelProperty =
            DependencyProperty.Register("SelectedTargetLevel", typeof(int), typeof(InstanceExpCalculator), new PropertyMetadata(0));

        private int m_SelectedStartStage;
        public int SelectedStartStage
        {
            get { return m_SelectedStartStage; }
            set
            {
                m_SelectedStartStage = value;
                FetchPossibleEndStages();
            }
        }

        public int SelectedEndStage
        {
            get { return (int)GetValue(SelectedEndStageProperty); }
            set { SetValue(SelectedEndStageProperty, value); }
        }
        // Using a DependencyProperty as the backing store for SelectedEndStage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedEndStageProperty =
            DependencyProperty.Register("SelectedEndStage", typeof(int), typeof(InstanceExpCalculator), new PropertyMetadata(0));

        public List<int> ArenaStages { get; set; }
        public ObservableCollection<int> PossibleEndStages { get; set; }

        public double GainedExpPercentage
        {
            get { return (double)GetValue(GainedExpPercentageProperty); }
            set { SetValue(GainedExpPercentageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GainedExpPercentage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GainedExpPercentageProperty =
            DependencyProperty.Register("GainedExpPercentage", typeof(double), typeof(InstanceExpCalculator), new PropertyMetadata(0.0));


        public string TotalExperience
        {
            get { return (string)GetValue(TotalExperienceProperty); }
            set { SetValue(TotalExperienceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for m_ScrollPrices.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalExperienceProperty =
            DependencyProperty.Register("TotalExperience", typeof(string), typeof(InstanceExpCalculator), new PropertyMetadata(null));

        public string ScrollsCount
        {
            get { return (string)GetValue(ScrollsCountProperty); }
            set { SetValue(ScrollsCountProperty, value); }
        }
        // Using a DependencyProperty as the backing store for m_ScrollPrices.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScrollsCountProperty =
            DependencyProperty.Register("ScrollsCount", typeof(string), typeof(InstanceExpCalculator), new PropertyMetadata(null));

        public string MoneyForScrolls
        {
            get { return (string)GetValue(MoneyForScrollsProperty); }
            set { SetValue(MoneyForScrollsProperty, value); }
        }
        // Using a DependencyProperty as the backing store for m_ScrollPrices.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoneyForScrollsProperty =
            DependencyProperty.Register("MoneyForScrolls", typeof(string), typeof(InstanceExpCalculator), new PropertyMetadata(null));

        public string WeeksCount
        {
            get { return (string)GetValue(WeeksCountProperty); }
            set { SetValue(WeeksCountProperty, value); }
        }
        // Using a DependencyProperty as the backing store for m_WeeksCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WeeksCountProperty =
            DependencyProperty.Register("WeeksCount", typeof(string), typeof(InstanceExpCalculator), new PropertyMetadata(null));

        public string RemainingExperience
        {
            get { return (string)GetValue(RemainingExperienceProperty); }
            set { SetValue(RemainingExperienceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for RemainingExperience.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RemainingExperienceProperty =
            DependencyProperty.Register("RemainingExperience", typeof(string), typeof(InstanceExpCalculator), new PropertyMetadata(null));

        public string MoneyTotal
        {
            get { return (string)GetValue(MoneyTotalProperty); }
            set { SetValue(MoneyTotalProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MoneyTotal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoneyTotalProperty =
            DependencyProperty.Register("MoneyTotal", typeof(string), typeof(InstanceExpCalculator), new PropertyMetadata(null));

        //public ObservableCollection<int> m_LevelRanges { get; set; }
        private IResultFormatter m_ResultFormatter = new ResultFormatter();
        private IExpingCalculatorFactory m_CalculatorFactory = new CalculatorFactory();
        public InstanceExpCalculator()
        {
            LevelRanges = new List<int>();
            TargetLevelRanges = new ObservableCollection<int>();
            ArenaStages = new List<int>();
            PossibleEndStages = new ObservableCollection<int>();
            InitializeComponent();
            FetchAllLevelRanges();
            FetchPossibleTargetLevelRanges();
            DataContext = this;
            FetchStartBossStages();
            FetchPossibleEndStages();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceExpCalculator"/> class. For unit testing purposes only
        /// </summary>
        /// <param name="calculatorFactory">The calculator factory.</param>
        public InstanceExpCalculator(IExpingCalculatorFactory calculatorFactory = null)
        {
            m_CalculatorFactory = calculatorFactory;
        }

        private void FetchStartBossStages()
        {
            foreach (var stage in ArenaRewardPerLevelRange.ArenaStages)
            {
                ArenaStages.Add(stage);
            }
            SelectedStartStage = ArenaStages.FirstOrDefault();
        }
        private void FetchPossibleEndStages()
        {
            PossibleEndStages.Clear();
            int stage = SelectedStartStage;
            int maxStage = SelectedStartStage + 3;
            do
            {
                if (ArenaStages.Contains(stage))
                {
                    PossibleEndStages.Add(stage);
                }
                stage++;

            } while (stage <= maxStage);
            SelectedEndStage = PossibleEndStages.LastOrDefault();
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
        private void FetchPossibleTargetLevelRanges()
        {
            TargetLevelRanges.Clear();
            int index = LevelRanges.IndexOf(SelectedStartLevel) + 1;
            for (int i = index; i < LevelRanges.Count; i++)
            {
                TargetLevelRanges.Add(LevelRanges.ElementAt(i));
            }
            SelectedTargetLevel = TargetLevelRanges.FirstOrDefault();
        }
        private void CalculateExping()
        {
                var instanceExpingCalculator = m_CalculatorFactory.CreateExpingCalculator();
                var result = instanceExpingCalculator.CalculateExping
                    (SelectedStartLevel, 
                    SelectedTargetLevel, 
                    GainedExpPercentage,
                    SelectedStartStage,
                    SelectedEndStage,
                    ArenaEnabled, 
                    BaiumEnabled,
                    ZakenEnabled,
                    AntharasEnabled,
                    DailyQuestsEnabled);
                if (result != null)
                {
                    ScrollsCount = m_ResultFormatter.ScrollsCount(result);
                    MoneyForScrolls = m_ResultFormatter.ScrollPrices(result);
                }
                TotalExperience = m_ResultFormatter.TotalExperience(result);
                WeeksCount = m_ResultFormatter.WeeksCount(result);
                RemainingExperience = m_ResultFormatter.RemainingExperience(result);
                MoneyTotal = m_ResultFormatter.MoneyTotal(result.CollectedScrolls);
        }

        private void btCalculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateExping();
        }

        private void slidGainedExp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            CalculateExping();
        }
    }
}
