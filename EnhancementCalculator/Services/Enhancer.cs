using EnhancementCalculator.Constants;

namespace EnhancementCalculator.Services
{
    public static class Enhancer
    {
        public static (int patack, int matack) EnhanceItem(int basePatak, int baseMatak, int enhancementLevel, WeaponType weaponType)
        {
            int finalPatack = basePatak;
            int finalMatack = baseMatak;
            var enhancementBonus = GetEnhancementBonus(weaponType);
            if (enhancementLevel>3)
            {
                finalPatack += enhancementBonus.patack * 3;
                finalMatack += enhancementBonus.matack * 3;
                int overEnhancementLevel = enhancementLevel - 3;
                finalPatack += overEnhancementLevel * enhancementBonus.patack * 2;
                finalMatack += overEnhancementLevel * enhancementBonus.matack * 2;
            }
            else
            {
                finalPatack += enhancementLevel * enhancementBonus.patack;
                finalMatack += enhancementLevel * enhancementBonus.matack;
            }
            return (finalPatack, finalMatack);
        }

        private static (int patack, int matack) GetEnhancementBonus(WeaponType weaponType)
        {
            int patackBonus = 0;
            int matackBonus = 0;
            switch (weaponType)
            {
                case WeaponType.Daggers:
                case WeaponType.OnehandedSwords:
                case WeaponType.OnehandedBlunts:
                    patackBonus = 4;
                    matackBonus = 3;
                    break;
                case WeaponType.TwohandedSwords:
                case WeaponType.TwohandedBlunts:
                case WeaponType.DualSwords:
                case WeaponType.Fists:
                    patackBonus = 5;
                    matackBonus = 3;
                    break;
                case WeaponType.Bows:
                    patackBonus = 8;
                    matackBonus = 3;
                    break;
                default:
                    break;
            }
            return (patackBonus, matackBonus);
        }
    }
}
