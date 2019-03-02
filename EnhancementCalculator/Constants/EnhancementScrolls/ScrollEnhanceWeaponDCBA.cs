namespace EnhancementCalculator.Constants.EnhancementScrolls
{
    internal class ScrollEnhanceWeaponDCBA : IEnhancementScroll
    {
        private const int m_OnehandedBonus = 4;
        private const int m_TwoHandedBonus = 5;
        private const int m_BowBonus = 8;
        private const int m_MagicalStatBonus = 3;

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
                    return (0,0);
            }
        }

    }
}
