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
            {Resource.DemonStaff, WeaponBaseStats.DemonStaff},
            {Resource.StaffOfEvilSpirit, WeaponBaseStats.StaffOfEvilSpirit},
            {Resource.GnomeHammer, WeaponBaseStats.GnomeHammer},
            {Resource.DesparionStaff, WeaponBaseStats.DesparionStaff},
            {Resource.BranchOfMotherTree, WeaponBaseStats.BranchOfMotherTree},
            {Resource.DaemonCrystall, WeaponBaseStats.DaemonCrystall},
            {Resource.IceStormHammer, WeaponBaseStats.IceStormHammer},
            {Resource.StarOfPain, WeaponBaseStats.StarOfPain},
            {Resource.DoomCrusher, WeaponBaseStats.DoomCrusher},
            {Resource.BeastTrident, WeaponBaseStats.BeastTrident}
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> OnehandedSwords = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.MysticalSword, WeaponBaseStats.MysticalSword},
            {Resource.Homuncul, WeaponBaseStats.Homuncul},
            {Resource.Katana, WeaponBaseStats.Katana},
            {Resource.EclipseSword, WeaponBaseStats.EclipseSword},
            {Resource.SwordOfValhalla, WeaponBaseStats.SwordOfValhalla},
            {Resource.WizardsTears, WeaponBaseStats.WizardsTears},
            {Resource.SLS, WeaponBaseStats.SLS},
            {Resource.ElementalSword, WeaponBaseStats.ElementalSword},
            {Resource.SwordOfMiracles, WeaponBaseStats.SwordOfMiracles},
            {Resource.Damaskus, WeaponBaseStats.Damaskus},
            {Resource.TemisTongue, WeaponBaseStats.TemisTongue},
            {Resource.DarkLegionsEdge, WeaponBaseStats.DarkLegionsEdge},
            {Resource.SirrasBlade, WeaponBaseStats.SirrasBlade}
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> OnehandedBlunts = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.EclipseAxe, WeaponBaseStats.EclipseAxe},
            {Resource.SpellBreaker, WeaponBaseStats.SpellBreaker},
            {Resource.KaimVanul, WeaponBaseStats.KaimVanul},
            {Resource.Yaksa, WeaponBaseStats.Yaksa},
            {Resource.BurningDragonSkull, WeaponBaseStats.BurningDragonSkull},
            {Resource.DeadmensGlory, WeaponBaseStats.DeadmensGlory},
            {Resource.CabriosHand, WeaponBaseStats.CabriosHand},
            {Resource.Elysium, WeaponBaseStats.Elysium},
            {Resource.BarakielAxe, WeaponBaseStats.BarakielsAxe}
        };
        public static IReadOnlyDictionary<string, (int patack, int matack)> Daggers = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.HellKnife, WeaponBaseStats.HellKnife},
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
        public static IReadOnlyDictionary<string, (int patack, int matack)> Polearms = new Dictionary<string, (int patack, int matack)>()
        {
            {Resource.OrcPolearm, WeaponBaseStats.OrcPolearm},
            {Resource.Pike, WeaponBaseStats.Pike},
            {Resource.Halberd, WeaponBaseStats.Halberd},
            {Resource.TallumGlave, WeaponBaseStats.TallumGlave},
            {Resource.TyphonPike, WeaponBaseStats.TyphonPike}
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
                case WeaponType.Polearms:
                    return Polearms;
                default:
                    return null;
            }
        }
    }
}
