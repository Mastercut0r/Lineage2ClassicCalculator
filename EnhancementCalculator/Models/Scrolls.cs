using EnhancementCalculator.Constants;
using System;

namespace EnhancementCalculator.Models
{
    class Scrolls : IScrolls
    {
        public int TenKkScrollCount { get; private set; }

        public int FiftyKkScrollCount { get; private set; }

        public int HundredKkScrollCount { get; private set; }

        public ulong TotalExp { get; private set; }

        public ulong TotalMoney { get; private set; }

        public Scrolls(int tenKkScrollCount, int fiftyKkScrollCount, int hundredKkScrollCount)
        {
            TenKkScrollCount = tenKkScrollCount;
            FiftyKkScrollCount = fiftyKkScrollCount;
            HundredKkScrollCount = hundredKkScrollCount;
            TotalExp = CalculateTotalExp();
            TotalMoney = CalculateTotalMoney();
        }

        private ulong CalculateTotalExp()
        {
            return (uint)TenKkScrollCount * ScrollConstants.tenMillExp + (uint)FiftyKkScrollCount * ScrollConstants.fiftyMillExp + (uint)HundredKkScrollCount * ScrollConstants.hundredMillExp;
        }

        private ulong CalculateTotalMoney()
        {
            return (uint)TenKkScrollCount * ScrollConstants.tenMilScrollPrice + (uint)FiftyKkScrollCount * ScrollConstants.fiftyMilScrollPrice + (uint)HundredKkScrollCount * ScrollConstants.hundredMilScrollPrice;
        }

        public ulong Add(IScrolls scrolls)
        {
            throw new NotImplementedException();
        }

        public static Scrolls operator+(Scrolls firstReward, Scrolls secondReward)
        {
            int ten = firstReward.TenKkScrollCount + secondReward.TenKkScrollCount;
            int fifty = firstReward.FiftyKkScrollCount + secondReward.FiftyKkScrollCount;
            int hundred = firstReward.HundredKkScrollCount + secondReward.HundredKkScrollCount;
            return new Scrolls(ten, fifty, hundred);
        }
        public static IScrolls CreateEmptyContainer()
        {
            return new Scrolls(0,0,0);
        }
    }
}
