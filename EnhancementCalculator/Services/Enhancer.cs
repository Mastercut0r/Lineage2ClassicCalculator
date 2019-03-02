using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    internal static class Enhancer
    {
        private const double ssBonusDCB = 0.4;
        private const double ssBonusA = 0.5;
        private const double ssBonusS = 0.7;
        public static (int patack, int matack) EnhanceItem(Weapon weapon, int enhanceTo)
        {
            int finalPatack = weapon.BaseStats.patack;
            int finalMatack = weapon.BaseStats.matack;
            var enhancementBonus =  weapon.EnhancementScroll.GetEnhancementBonus(weapon.Class);
            if (enhanceTo > 3)
            {
                finalPatack += enhancementBonus.patack * 3;
                finalMatack += enhancementBonus.matack * 3;
                int overEnhancementLevel = enhanceTo - 3;
                finalPatack += overEnhancementLevel * enhancementBonus.patack * 2;
                finalMatack += overEnhancementLevel * enhancementBonus.matack * 2;
            }
            else
            {
                finalPatack += enhanceTo * enhancementBonus.patack;
                finalMatack += enhanceTo * enhancementBonus.matack;
            }
            return (finalPatack, finalMatack);
        }

        public static double CalculateSsBonus(int enhanceTo, WeaponGrade grade)
        {
            return enhanceTo * GetSsBonus(grade);
        }

        private static double GetSsBonus(WeaponGrade grade)
        {
            switch (grade)
            {
                case WeaponGrade.D:
                    return ssBonusDCB;
                case WeaponGrade.C:
                    return ssBonusDCB;
                case WeaponGrade.B:
                    return ssBonusDCB;
                case WeaponGrade.A:
                    return ssBonusA;
                case WeaponGrade.S:
                    return ssBonusS;
                default:
                    return 0;
            }
        }
    }
}
