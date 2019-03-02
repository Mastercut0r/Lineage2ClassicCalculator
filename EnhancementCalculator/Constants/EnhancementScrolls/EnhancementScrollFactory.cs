using EnhancementCalculator.Models;
using System;

namespace EnhancementCalculator.Constants.EnhancementScrolls
{
    internal class EnhancementScrollFactory : IEnhancementScrollFactory
    {
        public IEnhancementScroll CreateScroll(WeaponGrade weaponGrade)
        {
            switch (weaponGrade)
            {
                case WeaponGrade.D:
                case WeaponGrade.C:
                case WeaponGrade.B:
                case WeaponGrade.A:
                    return new ScrollEnhanceWeaponDCBA();
                case WeaponGrade.S:
                    return new ScrollEnhanceWeaponS();
                default:
                    throw new ArgumentException($"{nameof(weaponGrade)} is not implemented");
            }
        }
    }
}
