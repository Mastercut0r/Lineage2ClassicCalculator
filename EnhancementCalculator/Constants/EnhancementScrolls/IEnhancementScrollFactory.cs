using EnhancementCalculator.Models;

namespace EnhancementCalculator.Constants.EnhancementScrolls
{
    internal interface IEnhancementScrollFactory
    {
        IEnhancementScroll CreateScroll(WeaponGrade weaponClass);
    }
}
