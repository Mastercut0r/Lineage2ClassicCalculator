namespace EnhancementCalculator.Constants.EnhancementScrolls
{
    internal interface IEnhancementScroll
    {
        //int OnehandedBonus { get; }
        //int TwoHandedBonus { get; }
        //int BowBonus { get; }
        //int MagicalStatBonus { get; }

        (int patack, int matack) GetEnhancementBonus(WeaponClass weaponType);
    }
}
