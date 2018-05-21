using EnhancementCalculator.Constants;
using EnhancementCalculator.Services;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace EnhancementCalculator
{
    /// <summary>
    /// Interaction logic for ItemEnhancer.xaml
    /// </summary>
    public partial class ItemEnhancer : UserControl
    {
        private IReadOnlyDictionary<string, (int patack, int matack)> itemsToEnhance;
        public ItemEnhancer()
        {
            InitializeComponent();
            InitWeaponTypes();
            InitEnhancementLevels();
        }

        private void InitEnhancementLevels()
        {
            for (int i = 0; i < 21; i++)
            {
                EnhancementLevelBox.Items.Add(i);
            }
        }

        private void InitWeaponTypes()
        {
            foreach (var weaponType in Enum.GetValues(typeof(WeaponType)))
            {
                WeapontypeBox.Items.Add(weaponType);
            }
        }

        private string RecalculateStats()
        {
            WeaponType selectedWeaponType;
            Enum.TryParse(WeapontypeBox.Text, out selectedWeaponType);
            var baseStats = itemsToEnhance[EnhancedItemsBox.SelectedValue.ToString()];
            var finalStats = Enhancer.EnhanceItem(baseStats.patack, baseStats.matack, Convert.ToUInt16(EnhancementLevelBox.SelectedValue), selectedWeaponType);
            return $"Total: {finalStats.patack}/{finalStats.matack} = (Base: {baseStats.patack}/{baseStats.matack} + Bonus: {finalStats.patack - baseStats.patack}/{finalStats.matack - baseStats.matack})";
        }

        private void EnhancedItemsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EnhancedItemsBox.SelectedValue!=null)
            {
                TotalPhysicalStatText.Content = RecalculateStats();
            }
        }

        private void EnhancementLevelBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EnhancedItemsBox.SelectedValue != null)
            {
                TotalPhysicalStatText.Content = RecalculateStats();
            }
        }

        private void WeapontypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedWeaponType = Convert.ToString(WeapontypeBox.SelectedValue);
            WeaponType selectedItemType;
            Enum.TryParse(selectedWeaponType, out selectedItemType);
            itemsToEnhance = WeaponsTable.GetWeaponTable(selectedItemType);
            InitWeapons();
            ResetEnhancementLevel();
        }

        private void InitWeapons()
        {
            EnhancedItemsBox.Items.Clear();
            foreach (var item in itemsToEnhance)
            {
                EnhancedItemsBox.Items.Add(item.Key);
            }
        }

        private void ResetEnhancementLevel()
        {
            EnhancementLevelBox.SelectedIndex = 0;
        }
    }
}
