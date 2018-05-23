using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using EnhancementCalculator.Services;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace EnhancementCalculator
{
    /// <summary>
    /// Interaction logic for InstanceExpCalculator.xaml
    /// </summary>
    public partial class InstanceExpCalculator : UserControl
    {
        public InstanceExpCalculator()
        {
            InitializeComponent();
            FetchLevelRanges();
        }
        private void FetchLevelRanges()
        {
            foreach (var level in ExperienceForLevelTable.ExperienceForLevel)
            {
                cboxYourLvl.Items.Add(level.Key);
                cboxTargetLvl.Items.Add(level.Key);
            }
            cboxTargetLvl.Items.RemoveAt(0);
            cboxYourLvl.SelectedItem = cboxYourLvl.Items.GetItemAt(0);
            cboxTargetLvl.SelectedItem = cboxYourLvl.Items.GetItemAt(1);
        }
        private void CalculateExping()
        {
            if (ValidateControls())
            {
                ushort startLevel = Convert.ToUInt16(cboxYourLvl.Text);
                ushort targetLevel = Convert.ToUInt16(cboxTargetLvl.Text);
                ushort gainedExpPercentage = Convert.ToUInt16(slidGainedExp.Value);
                int arenaRbCount = Convert.ToInt32(cboxArenaRbCount.Text);
                var instanceExpingCalculator = new InstanceExpingCalculator();
                var result = instanceExpingCalculator.CalculateExping(startLevel, targetLevel, gainedExpPercentage, (bool)ckArena.IsChecked, (bool)ckBaium.IsChecked, (bool)ckAntharas.IsChecked, arenaRbCount, 0);
                if (result != null)
                {
                    DisplayScrollCount(result);
                    DisplayScrollPrices(result);
                }
                VisualizeResults(result);
            }
        }
        private bool ValidateControls()
        {
            if (string.IsNullOrEmpty(cboxYourLvl.Text)) return false;
            if (string.IsNullOrEmpty(cboxTargetLvl.Text)) return false;
            if (string.IsNullOrEmpty(cboxArenaRbCount.Text)) return false;

            return true;
        }

        private void DisplayScrollCount(LevelingContainer result)
        {
            StringBuilder scrollPrices = new StringBuilder();
            string delimeter = ", ";
            if (result.HundertKkScrollNeeded > 0)
            {
                scrollPrices.Append($"100kk exp scrolls: [{result.HundertKkScrollNeeded}]");
            }
            if (result.FiftyKkScrollNeeded > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"50kk exp scrolls: [{result.FiftyKkScrollNeeded}]");
            }
            if (result.TenKkScrollNeeded > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"10kk exp scrolls: [{result.TenKkScrollNeeded}]");
            }
            lblScrollsNeeded.Content = scrollPrices.ToString();
        }
        private void DisplayScrollPrices(LevelingContainer result)
        {
            StringBuilder scrollPrices = new StringBuilder();
            string delimeter = ", ";
            if (result.HundertKkScrollNeeded > 0)
                scrollPrices.Append($"{result.HundertKkScrollNeeded} scrolls x 500k = [{string.Format("{0,9:N0}", result.HundertKkScrollNeeded * ExpScrollPrices.hundertKkExpScrollPrice)} Aden]");
            if (result.FiftyKkScrollNeeded > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"{result.FiftyKkScrollNeeded} scrolls x 400k = [{string.Format("{0,9:N0}", result.FiftyKkScrollNeeded * ExpScrollPrices.fiftyKkExpScrollPrice)} Aden]");
            }
            if (result.TenKkScrollNeeded > 0)
            {
                if (scrollPrices.Length > 0)
                {
                    scrollPrices.Append(delimeter);
                    scrollPrices.Append(Environment.NewLine);
                }
                scrollPrices.Append($"{result.TenKkScrollNeeded} scrolls x 100k = [{string.Format("{0,9:N0}", result.TenKkScrollNeeded * ExpScrollPrices.tenKkExpScrollPrice)} Aden]");
            }
            lblMoneyNeeded.Content = scrollPrices.ToString();
        }
        private void VisualizeResults(LevelingContainer result)
        {
            lblExpNeeded.Content = string.Format("{0,9:N0}", result?.TotalExperience);
            lblWeeksNeeded.Content = string.Format("{0,2:N0}", result?.WeeklyCyclesNeeded);
            lblRemainingExp.Content = string.Format("{0,9:N0}", result?.RemainingExperience);
            lblMoneyTotal.Content = $"{string.Format("{0,9:N0}", result?.MoneyTotal)} Aden";
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
