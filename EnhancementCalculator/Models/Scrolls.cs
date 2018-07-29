using EnhancementCalculator.Constants;
using System;

namespace EnhancementCalculator.Models
{
    class Scrolls : IScrolls
    {
        public int OneMillDailyScrolls { get; private set; }
        public int TenMillDailyScrolls { get; private set; }

        public int TenKkScrollCount { get; private set; }

        public int FiftyKkScrollCount { get; private set; }

        public int HundredKkScrollCount { get; private set; }

        public ulong TotalExp { get; private set; }

        public ulong TotalMoney { get; private set; }

        public Scrolls(int tenKkScrollCount, int fiftyKkScrollCount, int hundredKkScrollCount, int oneMillDailyScrolls, int tenMillDailyScrolls)
        {
            TenKkScrollCount = tenKkScrollCount;
            FiftyKkScrollCount = fiftyKkScrollCount;
            HundredKkScrollCount = hundredKkScrollCount;

            OneMillDailyScrolls = oneMillDailyScrolls;
            TenMillDailyScrolls = tenMillDailyScrolls;

            TotalExp = CalculateTotalExp();
            TotalMoney = CalculateTotalMoney();
        }

        public Scrolls(int tenKkScrollCount, int fiftyKkScrollCount, int hundredKkScrollCount) : this(tenKkScrollCount, fiftyKkScrollCount, hundredKkScrollCount, 0, 0)
        {}

        public Scrolls(int oneMillDailyScrolls, int tenMillDailyScrolls) : this (0,0,0, oneMillDailyScrolls, tenMillDailyScrolls)
        {}

        private ulong CalculateTotalExp()
        {
            return (uint)TenKkScrollCount * ScrollConstants.tenMillExp + 
                (uint)FiftyKkScrollCount * ScrollConstants.fiftyMillExp + 
                (uint)HundredKkScrollCount * ScrollConstants.hundredMillExp +
                (uint)OneMillDailyScrolls * ScrollConstants.millExp +
                (uint)TenMillDailyScrolls * ScrollConstants.tenMillExp;
        }

        private ulong CalculateTotalMoney()
        {
            return (uint)TenKkScrollCount * ScrollConstants.tenMilScrollPrice + 
                (uint)FiftyKkScrollCount * ScrollConstants.fiftyMilScrollPrice + 
                (uint)HundredKkScrollCount * ScrollConstants.hundredMilScrollPrice;
        }

        public static Scrolls operator+(Scrolls firstReward, Scrolls secondReward)
        {
            int oneDaily = firstReward.OneMillDailyScrolls + secondReward.OneMillDailyScrolls;
            int tenDaily = firstReward.TenMillDailyScrolls + secondReward.TenMillDailyScrolls;

            int ten = firstReward.TenKkScrollCount + secondReward.TenKkScrollCount;
            int fifty = firstReward.FiftyKkScrollCount + secondReward.FiftyKkScrollCount;
            int hundred = firstReward.HundredKkScrollCount + secondReward.HundredKkScrollCount;
            return new Scrolls(ten, fifty, hundred, oneDaily, tenDaily);
        }
        public static IScrolls CreateEmptyContainer()
        {
            return new Scrolls(0,0,0);
        }
    }
}
