using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    public static class WeaponsTable
    {
        private static Dictionary<string, IWeapon> TwoHandedSwords = new Dictionary<string, IWeapon>()
        {
            {Resource.PaagrioSword, new Weapon(Resource.PaagrioSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.PaagrioSword)},
            {Resource.BerserkerSword, new Weapon(Resource.BerserkerSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.BerserkerSword)},
            {Resource.Greatsword, new Weapon(Resource.Greatsword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.Greatsword)},
            {Resource.GuardianSword, new Weapon(Resource.GuardianSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.GuardianSword)},
            {Resource.MasterInferno, new Weapon(Resource.MasterInferno, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.MasterInferno)},
            {Resource.DragonSlayer, new Weapon(Resource.DragonSlayer, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.DragonSlayer)},
            {Resource.IposSword, new Weapon(Resource.IposSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponBaseStats.IposSword)}
        };
        private static Dictionary<string, IWeapon> TwohandedBlunts = new Dictionary<string, IWeapon>()
        {
            {Resource.DemonStaff, new Weapon(Resource.DemonStaff, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.DemonStaff)},
            {Resource.StaffOfEvilSpirit, new Weapon(Resource.StaffOfEvilSpirit, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.StaffOfEvilSpirit)},
            {Resource.GnomeHammer, new Weapon(Resource.GnomeHammer, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.GnomeHammer)},
            {Resource.DesparionStaff, new Weapon(Resource.DesparionStaff, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.DesparionStaff)},
            {Resource.BranchOfMotherTree, new Weapon(Resource.BranchOfMotherTree, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.BranchOfMotherTree)},
            {Resource.DaemonCrystall, new Weapon(Resource.DaemonCrystall, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.DaemonCrystall)},
            {Resource.IceStormHammer, new Weapon(Resource.IceStormHammer, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.IceStormHammer)},
            {Resource.StarOfPain, new Weapon(Resource.StarOfPain, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.StarOfPain)},
            {Resource.DoomCrusher, new Weapon(Resource.DoomCrusher, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.DoomCrusher)},
            {Resource.BeastTrident, new Weapon(Resource.BeastTrident, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponBaseStats.BeastTrident)},
        };
        private static Dictionary<string, IWeapon> OnehandedSwords = new Dictionary<string, IWeapon>()
        {
            {Resource.MysticalSword, new Weapon(Resource.MysticalSword, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.MysticalSword)},
            {Resource.Homuncul, new Weapon(Resource.Homuncul, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.Homuncul)},
            {Resource.Katana, new Weapon(Resource.Katana, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.Katana)},
            {Resource.EclipseSword, new Weapon(Resource.EclipseSword, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.EclipseSword)},
            {Resource.SwordOfValhalla, new Weapon(Resource.SwordOfValhalla, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.SwordOfValhalla)},
            {Resource.WizardsTears, new Weapon(Resource.WizardsTears, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.WizardsTears)},
            {Resource.SLS, new Weapon(Resource.SLS, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.SLS)},
            {Resource.ElementalSword, new Weapon(Resource.ElementalSword, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.ElementalSword)},
            {Resource.SwordOfMiracles, new Weapon(Resource.SwordOfMiracles, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.SwordOfMiracles)},
            {Resource.Damaskus, new Weapon(Resource.Damaskus, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.Damaskus)},
            {Resource.TemisTongue, new Weapon(Resource.TemisTongue, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.TemisTongue)},
            {Resource.DarkLegionsEdge, new Weapon(Resource.DarkLegionsEdge, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.DarkLegionsEdge)},
            {Resource.SirrasBlade, new Weapon(Resource.SirrasBlade, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponBaseStats.SirrasBlade)},
        };
        private static Dictionary<string, IWeapon> OnehandedBlunts = new Dictionary<string, IWeapon>()
        {
            {Resource.EclipseAxe, new Weapon(Resource.EclipseAxe, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.EclipseAxe)},
            {Resource.SpellBreaker, new Weapon(Resource.SpellBreaker, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.SpellBreaker)},
            {Resource.KaimVanul, new Weapon(Resource.KaimVanul, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.KaimVanul)},
            {Resource.Yaksa, new Weapon(Resource.Yaksa, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.Yaksa)},
            {Resource.BurningDragonSkull, new Weapon(Resource.BurningDragonSkull, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.BurningDragonSkull)},
            {Resource.DeadmensGlory, new Weapon(Resource.DeadmensGlory, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.DeadmensGlory)},
            {Resource.CabriosHand, new Weapon(Resource.CabriosHand, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.CabriosHand)},
            {Resource.Elysium, new Weapon(Resource.Elysium, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.Elysium)},
            {Resource.BarakielAxe, new Weapon(Resource.BarakielAxe, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponBaseStats.BarakielsAxe)}
        };
        private static Dictionary<string, IWeapon> Daggers = new Dictionary<string, IWeapon>()
        {
            {Resource.HellKnife, new Weapon(Resource.HellKnife, WeaponType.MageWeapon, WeaponClass.Daggers, WeaponBaseStats.HellKnife)},
            {Resource.CrystalDagger, new Weapon(Resource.CrystalDagger, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponBaseStats.CrystalDagger)},
            {Resource.DemonDagger, new Weapon(Resource.DemonDagger, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponBaseStats.DemonDagger)},
            {Resource.SoulSeparator, new Weapon(Resource.SoulSeparator, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponBaseStats.SoulSeparator)},
            {Resource.StormNaga, new Weapon(Resource.StormNaga, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponBaseStats.StormNaga)},
        };
        private static Dictionary<string, IWeapon> Fists = new Dictionary<string, IWeapon>()
        {
            {Resource.GreatPata, new Weapon(Resource.GreatPata, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponBaseStats.GreatPata)},
            {Resource.BellionsCestus, new Weapon(Resource.BellionsCestus, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponBaseStats.BellionsCestus)},
            {Resource.DragonGrinder, new Weapon(Resource.DragonGrinder, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponBaseStats.DragonGrinder)},
            {Resource.SobbeksTempest, new Weapon(Resource.SobbeksTempest, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponBaseStats.SobbeksTempest)},
        };
        private static Dictionary<string, IWeapon> Bows = new Dictionary<string, IWeapon>()
        {
            {Resource.EminenceBow, new Weapon(Resource.EminenceBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponBaseStats.EminenceBow)},
            {Resource.BoP, new Weapon(Resource.BoP, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponBaseStats.BoP)},
            {Resource.CarnageBow, new Weapon(Resource.CarnageBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponBaseStats.CarnageBow)},
            {Resource.SoulBow, new Weapon(Resource.SoulBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponBaseStats.SoulBow)},
            {Resource.ShyidBow, new Weapon(Resource.ShyidBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponBaseStats.ShyidBow)},
        };
        private static Dictionary<string, IWeapon> DualSwords = new Dictionary<string, IWeapon>()
        {
            {Resource.DualKatana, new Weapon(Resource.DualKatana, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponBaseStats.DualKatana)},
            {Resource.DualSLS, new Weapon(Resource.DualSLS, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponBaseStats.DualSLS)},
            {Resource.DualDamaskus, new Weapon(Resource.DualDamaskus, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponBaseStats.DualDamaskus)},
            {Resource.DualTallumDamaskus, new Weapon(Resource.DualTallumDamaskus, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponBaseStats.DualTallumDamaskus)},
        };
        private static Dictionary<string, IWeapon> Polearms = new Dictionary<string, IWeapon>()
        {
            {Resource.OrcPolearm, new Weapon(Resource.OrcPolearm, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponBaseStats.OrcPolearm)},
            {Resource.Pike, new Weapon(Resource.Pike, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponBaseStats.Pike)},
            {Resource.Halberd, new Weapon(Resource.Halberd, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponBaseStats.Halberd)},
            {Resource.TallumGlave, new Weapon(Resource.TallumGlave, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponBaseStats.TallumGlave)},
            {Resource.TyphonPike, new Weapon(Resource.TyphonPike, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponBaseStats.TyphonPike)},
        };

        public static IReadOnlyDictionary<string, IWeapon> GetWeaponTable(WeaponClass type)
        {
            switch (type)
            {
                case WeaponClass.Daggers:
                    return new Dictionary<string, IWeapon>(Daggers);
                case WeaponClass.OnehandedSwords:
                    return new Dictionary<string, IWeapon>(OnehandedSwords);
                case WeaponClass.TwohandedSwords:
                    return new Dictionary<string, IWeapon>(TwoHandedSwords);
                case WeaponClass.Bows:
                    return new Dictionary<string, IWeapon>(Bows);
                case WeaponClass.OnehandedBlunts:
                    return new Dictionary<string, IWeapon>(OnehandedBlunts);
                case WeaponClass.TwohandedBlunts:
                    return new Dictionary<string, IWeapon>(TwohandedBlunts);
                case WeaponClass.Fists:
                    return new Dictionary<string, IWeapon>(Fists);
                case WeaponClass.DualSwords:
                    return new Dictionary<string, IWeapon>(DualSwords);
                case WeaponClass.Polearms:
                    return new Dictionary<string, IWeapon>(Polearms);
                default:
                    return null;
            }
        }
    }
}
