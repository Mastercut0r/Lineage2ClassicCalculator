using EnhancementCalculator.Constants;
using EnhancementCalculator.Services;

namespace EnhancementCalculator.Models
{
    public class Weapon : IWeapon
    {
        public string WeaponName
        {
            get;
        }

        public WeaponType Type
        {
            get;
        }

        public WeaponClass Class
        {
            get;
        }

        public (int patack, int matack) BaseStats
        {
            get;
        }

        public (int patack, int matack) FinalStats
        {
            get; private set;
        }

        public int EnhancementLevel
        {
            get;
        }

        public Weapon(string weaponName, WeaponType weaponType, WeaponClass weaponClass, (int patack, int matack) baseStats)
        {
            WeaponName = weaponName;
            Type = weaponType;
            Class = weaponClass;
            BaseStats = baseStats;
            FinalStats = (0,0);
        }

        public (int patack, int matack) EnhanceWeapon(int enhancementLevel)
        {
            FinalStats = Enhancer.EnhanceItem(BaseStats.patack, BaseStats.matack, enhancementLevel, Class);
            return FinalStats;
        }
    }
}
