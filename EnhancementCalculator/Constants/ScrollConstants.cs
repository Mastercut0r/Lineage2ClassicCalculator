using EnhancementCalculator.Models;

namespace EnhancementCalculator.Constants
{
    static class ScrollConstants
    {
        public const ulong millExp = 1000000;
        public const ulong tenMillExp = 10000000;
        public const ulong fiftyMillExp = 50000000;
        public const ulong hundredMillExp = 100000000;

        public static ulong tenMilScrollPrice = 100000;
        public static ulong fiftyMilScrollPrice = 400000;
        public static ulong hundredMilScrollPrice = 500000;

        public static IScrolls tenMil = new Scrolls(1,0,0);
        public static IScrolls thirtyMil = new Scrolls(3,0,0);
        public static IScrolls fiftyMil = new Scrolls(0,1,0);
        public static IScrolls eightyMil = new Scrolls(3,1,0);
        public static IScrolls hundredMil = new Scrolls(0,0,1);
        public static IScrolls hundredTwentyMil = new Scrolls(2, 0, 1);
        public static IScrolls hundredFortyMil = new Scrolls(4,0,1);
        public static IScrolls twoHundredMil = new Scrolls(0,0,2);
        public static IScrolls threeHundredMil = new Scrolls(0,0,3);
        public static IScrolls threeHundredFiftyMil = new Scrolls(0,1,3);
        public static IScrolls fourHundredMil = new Scrolls(0,0,4);
        public static IScrolls sixHundredMil = new Scrolls(0,0,6);
    }
}
