namespace EnhancementCalculator.Constants.EnhancementScrolls
{
    internal class ScrollEnhanceWeaponS : IEnhancementScroll
    {
        private const int m_OnehandedBonus = 5;
        private const int m_TwoHandedBonus = 6;
        private const int m_BowBonus = 10;
        private const int m_MagicalStatBonus = 4;

        //public int OnehandedBonus => m_OnehandedBonus;
        //public int TwoHandedBonus => m_TwoHandedBonus;
        //public int BowBonus => m_BowBonus;
        //public int MagicalStatBonus => m_MagicalStatBonus;

        public (int patack, int matack) GetEnhancementBonus(WeaponClass weaponType)
        {
            switch (weaponType)
            {
                case WeaponClass.OnehandedSwords:
                case WeaponClass.OnehandedBlunts:
                case WeaponClass.Daggers:
                case WeaponClass.Polearms:
                    return (m_OnehandedBonus, m_MagicalStatBonus);
                case WeaponClass.TwohandedSwords:
                case WeaponClass.TwohandedBlunts:
                case WeaponClass.DualSwords:
                case WeaponClass.Fists:
                    return (m_TwoHandedBonus, m_MagicalStatBonus);
                case WeaponClass.Bows:
                    return (m_BowBonus, m_MagicalStatBonus);
                default:
                    return (0, 0);
            }
        }
    }
}
