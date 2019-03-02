using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    public static class WeaponsTable
    {
        private static readonly Dictionary<string, IWeapon> TwoHandedSwords = new Dictionary<string, IWeapon>()
        {
            {Resource.SwordOfGiants, new Weapon(Resource.SwordOfGiants, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.D, WeaponBaseStats.SwordOfGiants) },
            {Resource.Claymore, new Weapon(Resource.Claymore, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.D, WeaponBaseStats.Claymore) },
            {Resource.PaagrioSword, new Weapon(Resource.PaagrioSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.C, WeaponBaseStats.PaagrioSword)},
            {Resource.BerserkerSword, new Weapon(Resource.BerserkerSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.C, WeaponBaseStats.BerserkerSword)},
            {Resource.Greatsword, new Weapon(Resource.Greatsword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.B, WeaponBaseStats.Greatsword)},
            {Resource.GuardianSword, new Weapon(Resource.GuardianSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.B, WeaponBaseStats.GuardianSword)},
            {Resource.MasterInferno, new Weapon(Resource.MasterInferno, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.A, WeaponBaseStats.MasterInferno)},
            {Resource.DragonSlayer, new Weapon(Resource.DragonSlayer, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.A, WeaponBaseStats.DragonSlayer)},
            {Resource.IposSword, new Weapon(Resource.IposSword, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.A, WeaponBaseStats.IposSword)},
            {Resource.HeavensDivider, new Weapon(Resource.HeavensDivider, WeaponType.PhysicalWeapon, WeaponClass.TwohandedSwords, WeaponGrade.S, WeaponBaseStats.HeavensDivider)}
        };
        private static readonly Dictionary<string, IWeapon> TwohandedBlunts = new Dictionary<string, IWeapon>()
        {
            {Resource.GiantsHammer, new Weapon(Resource.GiantsHammer, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.D, WeaponBaseStats.GiantsHammer)},
            {Resource.DemonStaff, new Weapon(Resource.DemonStaff, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.C, WeaponBaseStats.DemonStaff)},
            {Resource.StaffOfEvilSpirit, new Weapon(Resource.StaffOfEvilSpirit, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.B, WeaponBaseStats.StaffOfEvilSpirit)},
            {Resource.GnomeHammer, new Weapon(Resource.GnomeHammer, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.C, WeaponBaseStats.GnomeHammer)},
            {Resource.DesparionStaff, new Weapon(Resource.DesparionStaff, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.A, WeaponBaseStats.DesparionStaff)},
            {Resource.BranchOfMotherTree, new Weapon(Resource.BranchOfMotherTree, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.A, WeaponBaseStats.BranchOfMotherTree)},
            {Resource.DaemonCrystall, new Weapon(Resource.DaemonCrystall, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.A, WeaponBaseStats.DaemonCrystall)},
            {Resource.ImperialStaff, new Weapon(Resource.ImperialStaff, WeaponType.MageWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.S, WeaponBaseStats.ImperialStaff)},
            {Resource.IceStormHammer, new Weapon(Resource.IceStormHammer, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.B, WeaponBaseStats.IceStormHammer)},
            {Resource.StarOfPain, new Weapon(Resource.StarOfPain, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.B, WeaponBaseStats.StarOfPain)},
            {Resource.DoomCrusher, new Weapon(Resource.DoomCrusher, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.A, WeaponBaseStats.DoomCrusher)},
            {Resource.BeastTrident, new Weapon(Resource.BeastTrident, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.A, WeaponBaseStats.BeastTrident)},
            {Resource.DragonHunterAxe, new Weapon(Resource.DragonHunterAxe, WeaponType.PhysicalWeapon, WeaponClass.TwohandedBlunts, WeaponGrade.S, WeaponBaseStats.DragonHunterAxe)},
        };
        private static readonly Dictionary<string, IWeapon> OnehandedSwords = new Dictionary<string, IWeapon>()
        {
            {Resource.DemonFangs, new Weapon(Resource.DemonFangs, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.D, WeaponBaseStats.DemonFangs)},
            {Resource.MysticalSword, new Weapon(Resource.MysticalSword, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.C, WeaponBaseStats.MysticalSword)},
            {Resource.Homuncul, new Weapon(Resource.Homuncul, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.C, WeaponBaseStats.Homuncul)},
            {Resource.Katana, new Weapon(Resource.Katana, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponGrade.C, WeaponBaseStats.Katana)},
            {Resource.EclipseSword, new Weapon(Resource.EclipseSword, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.C, WeaponBaseStats.EclipseSword)},
            {Resource.SwordOfValhalla, new Weapon(Resource.SwordOfValhalla, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.B, WeaponBaseStats.SwordOfValhalla)},
            {Resource.WizardsTears, new Weapon(Resource.WizardsTears, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.B, WeaponBaseStats.WizardsTears)},
            {Resource.SLS, new Weapon(Resource.SLS, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponGrade.B, WeaponBaseStats.SLS)},
            {Resource.ElementalSword, new Weapon(Resource.ElementalSword, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.A, WeaponBaseStats.ElementalSword)},
            {Resource.SwordOfMiracles, new Weapon(Resource.SwordOfMiracles, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.A, WeaponBaseStats.SwordOfMiracles)},
            {Resource.Damaskus, new Weapon(Resource.Damaskus, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponGrade.B, WeaponBaseStats.Damaskus)},
            {Resource.TemisTongue, new Weapon(Resource.TemisTongue, WeaponType.MageWeapon, WeaponClass.OnehandedSwords, WeaponGrade.A, WeaponBaseStats.TemisTongue)},
            {Resource.DarkLegionsEdge, new Weapon(Resource.DarkLegionsEdge, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponGrade.A, WeaponBaseStats.DarkLegionsEdge)},
            {Resource.SirrasBlade, new Weapon(Resource.SirrasBlade, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponGrade.A, WeaponBaseStats.SirrasBlade)},
            {Resource.ForgottenBlade, new Weapon(Resource.ForgottenBlade, WeaponType.PhysicalWeapon, WeaponClass.OnehandedSwords, WeaponGrade.S, WeaponBaseStats.ForgottenBlade)},
        };
        private static readonly Dictionary<string, IWeapon> OnehandedBlunts = new Dictionary<string, IWeapon>()
        {
            {Resource.StaffOfLife, new Weapon(Resource.StaffOfLife, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.D, WeaponBaseStats.StaffOfLife)},
            {Resource.Tarbar, new Weapon(Resource.Tarbar, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.D, WeaponBaseStats.Tarbar)},
            {Resource.Bonebreaker, new Weapon(Resource.Bonebreaker, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.D, WeaponBaseStats.Bonebreaker)},
            {Resource.EclipseAxe, new Weapon(Resource.EclipseAxe, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.C, WeaponBaseStats.EclipseAxe)},
            {Resource.SpellBreaker, new Weapon(Resource.SpellBreaker, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.B, WeaponBaseStats.SpellBreaker)},
            {Resource.KaimVanul, new Weapon(Resource.KaimVanul, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.B, WeaponBaseStats.KaimVanul)},
            {Resource.Yaksa, new Weapon(Resource.Yaksa, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.C, WeaponBaseStats.Yaksa)},
            {Resource.BurningDragonSkull, new Weapon(Resource.BurningDragonSkull, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.A, WeaponBaseStats.BurningDragonSkull)},
            {Resource.DeadmensGlory, new Weapon(Resource.DeadmensGlory, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.B, WeaponBaseStats.DeadmensGlory)},
            {Resource.CabriosHand, new Weapon(Resource.CabriosHand, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.A, WeaponBaseStats.CabriosHand)},
            {Resource.ArcanaMace, new Weapon(Resource.ArcanaMace, WeaponType.MageWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.S, WeaponBaseStats.ArcanaMace)},
            {Resource.Elysium, new Weapon(Resource.Elysium, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.A, WeaponBaseStats.Elysium)},
            {Resource.BarakielAxe, new Weapon(Resource.BarakielAxe, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.A, WeaponBaseStats.BarakielsAxe)},
            {Resource.BasaltBattleHammer, new Weapon(Resource.BasaltBattleHammer, WeaponType.PhysicalWeapon, WeaponClass.OnehandedBlunts, WeaponGrade.S, WeaponBaseStats.BasaltBattleHammer)}
        };
        private static readonly Dictionary<string, IWeapon> Daggers = new Dictionary<string, IWeapon>()
        {
            {Resource.CursedMaingauche, new Weapon(Resource.CursedMaingauche, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.D, WeaponBaseStats.CursedMaingauche)},
            {Resource.Maingauche, new Weapon(Resource.Maingauche, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.D, WeaponBaseStats.Maingauche)},
            {Resource.MithrillDagger, new Weapon(Resource.MithrillDagger, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.D, WeaponBaseStats.MithrillDagger)},
            {Resource.HellKnife, new Weapon(Resource.HellKnife, WeaponType.MageWeapon, WeaponClass.Daggers, WeaponGrade.B, WeaponBaseStats.HellKnife)},
            {Resource.CrystalDagger, new Weapon(Resource.CrystalDagger, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.C, WeaponBaseStats.CrystalDagger)},
            {Resource.DemonDagger, new Weapon(Resource.DemonDagger, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.B, WeaponBaseStats.DemonDagger)},
            {Resource.SoulSeparator, new Weapon(Resource.SoulSeparator, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.A, WeaponBaseStats.SoulSeparator)},
            {Resource.StormNaga, new Weapon(Resource.StormNaga, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.A, WeaponBaseStats.StormNaga)},
            {Resource.AngelSlayer, new Weapon(Resource.AngelSlayer, WeaponType.PhysicalWeapon, WeaponClass.Daggers, WeaponGrade.S, WeaponBaseStats.AngelSlayer)},
        };
        private static readonly Dictionary<string, IWeapon> Fists = new Dictionary<string, IWeapon>()
        {
            {Resource.SpikedJamadhar, new Weapon(Resource.SpikedJamadhar, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponGrade.D, WeaponBaseStats.SpikedJamadhar)},
            {Resource.GreatPata, new Weapon(Resource.GreatPata, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponGrade.C, WeaponBaseStats.GreatPata)},
            {Resource.BellionsCestus, new Weapon(Resource.BellionsCestus, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponGrade.B, WeaponBaseStats.BellionsCestus)},
            {Resource.DragonGrinder, new Weapon(Resource.DragonGrinder, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponGrade.A, WeaponBaseStats.DragonGrinder)},
            {Resource.SobbeksTempest, new Weapon(Resource.SobbeksTempest, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponGrade.A, WeaponBaseStats.SobbeksTempest)},
            {Resource.DemonSplinter, new Weapon(Resource.DemonSplinter, WeaponType.PhysicalWeapon, WeaponClass.Fists, WeaponGrade.S, WeaponBaseStats.DemonSplinter)},
        };
        private static readonly Dictionary<string, IWeapon> Bows = new Dictionary<string, IWeapon>()
        {
            {Resource.LightCrossbow, new Weapon(Resource.LightCrossbow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.D, WeaponBaseStats.LightCrossbow)},
            {Resource.EminenceBow, new Weapon(Resource.EminenceBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.C, WeaponBaseStats.EminenceBow)},
            {Resource.BoP, new Weapon(Resource.BoP, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.B, WeaponBaseStats.BoP)},
            {Resource.CarnageBow, new Weapon(Resource.CarnageBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.A, WeaponBaseStats.CarnageBow)},
            {Resource.SoulBow, new Weapon(Resource.SoulBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.A, WeaponBaseStats.SoulBow)},
            {Resource.ShyidBow, new Weapon(Resource.ShyidBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.A, WeaponBaseStats.ShyidBow)},
            {Resource.DraconicBow, new Weapon(Resource.DraconicBow, WeaponType.PhysicalWeapon, WeaponClass.Bows, WeaponGrade.S, WeaponBaseStats.DraconicBow)},
        };
        private static readonly Dictionary<string, IWeapon> DualSwords = new Dictionary<string, IWeapon>()
        {
            {Resource.DualTopD, new Weapon(Resource.DualTopD, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponGrade.D, WeaponBaseStats.DualTopD)},
            {Resource.DualKatana, new Weapon(Resource.DualKatana, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponGrade.C, WeaponBaseStats.DualKatana)},
            {Resource.DualSLS, new Weapon(Resource.DualSLS, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponGrade.B, WeaponBaseStats.DualSLS)},
            {Resource.DualDamaskus, new Weapon(Resource.DualDamaskus, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponGrade.A, WeaponBaseStats.DualDamaskus)},
            {Resource.DualTallumDamaskus, new Weapon(Resource.DualTallumDamaskus, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponGrade.A, WeaponBaseStats.DualTallumDamaskus)},
            {Resource.DualTallumDarkLegion, new Weapon(Resource.DualTallumDarkLegion, WeaponType.PhysicalWeapon, WeaponClass.DualSwords, WeaponGrade.S, WeaponBaseStats.DualTallumDarkLegion)},
        };
        private static readonly Dictionary<string, IWeapon> Polearms = new Dictionary<string, IWeapon>()
        {
            {Resource.Glaive, new Weapon(Resource.Glaive, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.D, WeaponBaseStats.Glaive)},
            {Resource.OrcPolearm, new Weapon(Resource.OrcPolearm, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.C, WeaponBaseStats.OrcPolearm)},
            {Resource.Pike, new Weapon(Resource.Pike, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.B, WeaponBaseStats.Pike)},
            {Resource.Halberd, new Weapon(Resource.Halberd, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.A, WeaponBaseStats.Halberd)},
            {Resource.TallumGlave, new Weapon(Resource.TallumGlave, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.A, WeaponBaseStats.TallumGlave)},
            {Resource.TyphonPike, new Weapon(Resource.TyphonPike, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.A, WeaponBaseStats.TyphonPike)},
            {Resource.SaintSpear, new Weapon(Resource.SaintSpear, WeaponType.PhysicalWeapon, WeaponClass.Polearms, WeaponGrade.S, WeaponBaseStats.SaintSpear)},
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
