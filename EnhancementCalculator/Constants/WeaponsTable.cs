using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    public static class WeaponsTable
    {
        public static IReadOnlyDictionary<string, (int patack, int matack)> TwoHandedSwords = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.PaagrioSword, WeaponBaseStats.PaagrioSword},
            {Resource.BerserkerSword, WeaponBaseStats.BerserkerSword},
            {Resource.Greatsword, WeaponBaseStats.GreatSword},
            {Resource.GuardianSword, WeaponBaseStats.GuardianSword},
            {Resource.MasterInferno, WeaponBaseStats.MasterInferno},
            {Resource.DragonSlayer, WeaponBaseStats.DragonSlayer},
            {Resource.IposSword, WeaponBaseStats.IposSword},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> TwohandedBlunts = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.GnomeHammer, WeaponBaseStats.GnomeHammer},
            {Resource.IceStormHammer, WeaponBaseStats.IceStormHammer},
            {Resource.StarOfPain, WeaponBaseStats.StarOfPain},
            {Resource.DoomCrusher, WeaponBaseStats.DoomCrusher},
            {Resource.BeastTrident, WeaponBaseStats.BeastTrident},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> OnehandedSwords = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.Katana, WeaponBaseStats.Katana},
            {Resource.SLS, WeaponBaseStats.SLS},
            {Resource.Damaskus, WeaponBaseStats.Damaskus},
            {Resource.DarkLegionsEdge, WeaponBaseStats.DarkLegionsEdge},
            {Resource.SirrasBlade, WeaponBaseStats.SirrasBlade},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> OnehandedBlunts = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.Yaksa, WeaponBaseStats.Yaksa},
            {Resource.DeadmensGlory, WeaponBaseStats.DeadmensGlory},
            {Resource.Elysium, WeaponBaseStats.Elysium},
            {Resource.BarakielAxe, WeaponBaseStats.BarakielsAxe},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> Daggers = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.CrystalDagger, WeaponBaseStats.CrystalDagger},
            {Resource.DemonDagger, WeaponBaseStats.DemonDagger},
            {Resource.SoulSeparator, WeaponBaseStats.SoulSeparator},
            {Resource.StormNaga, WeaponBaseStats.StormNaga},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> Fists = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.GreatPata, WeaponBaseStats.GreatPata},
            {Resource.BellionsCestus, WeaponBaseStats.BellionsCestus},
            {Resource.DragonGrinder, WeaponBaseStats.DragonGrinder},
            {Resource.SobbeksTempest, WeaponBaseStats.SobbeksTempest},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> Bows = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.EminenceBow, WeaponBaseStats.EminenceBow},
            {Resource.BoP, WeaponBaseStats.BoP},
            {Resource.CarnageBow, WeaponBaseStats.CarnageBow},
            {Resource.SoulBow, WeaponBaseStats.SoulBow},
            {Resource.ShyidBow, WeaponBaseStats.ShyidBow},
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> DualSwords = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.DualKatana, WeaponBaseStats.DualKatana},
            {Resource.DualSLS, WeaponBaseStats.DualSLS},
            {Resource.DualDamaskus, WeaponBaseStats.DualDamaskus},
            {Resource.DualTallumDamaskus, WeaponBaseStats.DualTallumDamaskus},
        };

        public static IReadOnlyDictionary<string, (int patack, int matack)> GetWeaponTable(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Daggers:
                    return Daggers;
                case WeaponType.OnehandedSwords:
                    return OnehandedSwords;
                case WeaponType.TwohandedSwords:
                    return TwoHandedSwords;
                case WeaponType.Bows:
                    return Bows;
                case WeaponType.OnehandedBlunts:
                    return OnehandedBlunts;
                case WeaponType.TwohandedBlunts:
                    return TwohandedBlunts;
                case WeaponType.Fists:
                    return Fists;
                case WeaponType.DualSwords:
                    return DualSwords;
                default:
                    return null;
            }
        }
    }
}
