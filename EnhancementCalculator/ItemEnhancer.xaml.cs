using EnhancementCalculator.Constants;
using EnhancementCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace EnhancementCalculator
{
    /// <summary>
    /// Interaction logic for ItemEnhancer.xaml
    /// </summary>
    public partial class ItemEnhancer : UserControl
    {
        private IReadOnlyDictionary<string, IWeapon> _itemsToEnhance;
        public ItemEnhancer()
        {
            InitializeComponent();
            InitWeaponTypes();
            InitEnhancementLevels();

            Rb_SortByP.IsChecked = true;
            Rb_ShowAll.IsChecked = true;
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
            foreach (var weaponType in Enum.GetValues(typeof(WeaponClass)))
            {
                WeapontypeBox.Items.Add(weaponType);
            }
        }

        private string RecalculateStats()
        {
            var weapon = _itemsToEnhance[EnhancedItemsBox.SelectedValue.ToString()];
            weapon.EnhanceWeapon(Convert.ToUInt16(EnhancementLevelBox.SelectedValue));
            return $"Total: {weapon.FinalStats.patack}/{weapon.FinalStats.matack} = (Base: {weapon.FinalStats.patack}/{weapon.FinalStats.matack} + Bonus: {weapon.FinalStats.patack - weapon.BaseStats.patack}/{weapon.FinalStats.matack - weapon.BaseStats.matack})";
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
            WeaponClass selectedItemType = GetSelectedWeaponClass();
            _itemsToEnhance = WeaponsTable.GetWeaponTable(selectedItemType);
            InitWeapons();
            ResetEnhancementLevel();
        }

        private WeaponClass GetSelectedWeaponClass()
        {
            var selectedWeaponType = Convert.ToString(WeapontypeBox.SelectedValue);
            WeaponClass selectedItemType;
            Enum.TryParse(selectedWeaponType, out selectedItemType);
            return selectedItemType;
        }

        private void InitWeapons()
        {
            var sortedWeapons = ApplySortingSelection();
            if (sortedWeapons!=null)
            {
                EnhancedItemsBox.Items.Clear();
                foreach (var item in sortedWeapons)
                {
                    EnhancedItemsBox.Items.Add(item.Key);
                }
            }
        }
        private void ResetEnhancementLevel()
        {
            EnhancementLevelBox.SelectedIndex = 0;
        }

        private void Rb_ShowAll_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            if (_itemsToEnhance!=null && _itemsToEnhance.Any())
            {
                WeaponClass selectedItemType = GetSelectedWeaponClass();
                _itemsToEnhance = WeaponsTable.GetWeaponTable(selectedItemType);
                InitWeapons();
            }
        }

        private void Rb_Phys_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
                WeaponClass selectedItemType = GetSelectedWeaponClass();
                _itemsToEnhance = WeaponsTable.GetWeaponTable(selectedItemType).Where(x=>x.Value.Type == WeaponType.PhysicalWeapon).ToDictionary(x=>x.Key, x=>x.Value);
                InitWeapons();
        }

        private void Rb_Mage_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
                WeaponClass selectedItemType = GetSelectedWeaponClass();
                _itemsToEnhance = WeaponsTable.GetWeaponTable(selectedItemType).Where(x => x.Value.Type == WeaponType.MageWeapon).ToDictionary(x => x.Key, x => x.Value);
                InitWeapons();
        }

        private void Rb_SortByP_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            InitWeapons();
        }
        private void Rb_SortByM_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            InitWeapons();
        }
        private IOrderedEnumerable<KeyValuePair<string, IWeapon>> ApplySortingSelection()
        {
            if (Rb_SortByM.IsChecked.HasValue)
            {
                 return Rb_SortByP.IsChecked == true ? AscendingOrderBy(x => x.Value.BaseStats.patack) : AscendingOrderBy(x => x.Value.BaseStats.matack);
            }
            return null;
        }
        private IOrderedEnumerable<KeyValuePair<string, IWeapon>> AscendingOrderBy(Func<KeyValuePair<string, IWeapon>, int> keySelector)
        {
            return _itemsToEnhance?.OrderBy(keySelector);
        }
    }
}
