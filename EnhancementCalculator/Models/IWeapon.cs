namespace EnhancementCalculator.Models
{
    public interface IWeapon
    {
        string WeaponName { get; }
        WeaponType Type { get; }
        (int patack, int matack) BaseStats { get; }
        (int patack, int matack) FinalStats { get; }
        (int patack, int matack) EnhanceWeapon(int enhancementLevel);
    }
}
