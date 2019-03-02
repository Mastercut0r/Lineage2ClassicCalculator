using EnhancementCalculator.Constants;
using EnhancementCalculator.Constants.EnhancementScrolls;
using EnhancementCalculator.Services;

namespace EnhancementCalculator.Models
{
    internal class Weapon : IWeapon
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

        public WeaponGrade Grade { get; }

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

        public IEnhancementScroll EnhancementScroll { get; }

        public double SsBonus { get; private set; }

        public Weapon(
            string weaponName, 
            WeaponType weaponType, 
            WeaponClass weaponClass, 
            WeaponGrade grade, 
            (int patack, int matack) baseStats,
            IEnhancementScrollFactory factory = null)
        {
            WeaponName = weaponName;
            Type = weaponType;
            Class = weaponClass;
            Grade = grade;
            BaseStats = baseStats;
            FinalStats = (0,0);
            var enhancementScrollFactory = factory ?? new EnhancementScrollFactory();
            EnhancementScroll = enhancementScrollFactory.CreateScroll(grade);
        }

        public (int patack, int matack) EnhanceWeapon(int enhancementLevel)
        {
            FinalStats = Enhancer.EnhanceItem(this, enhancementLevel);
            SsBonus = Enhancer.CalculateSsBonus(enhancementLevel, Grade);
            return FinalStats;
        }
    }
}
