using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    //    //https://4gameforum.com/threads/682002/
    public static class ArenaRewardPerLevelRange
    {
        public static IEnumerable<int> ArenaStages => SixtyLevels.Keys;
        public static IScrolls FortyLevels = ScrollConstants.tenMil;
        public static IScrolls FiftyLevels = ScrollConstants.thirtyMil;
        public static IReadOnlyDictionary<int, IScrolls> SixtyLevels = new Dictionary<int, IScrolls>()
        {
            {1, ScrollConstants.fiftyMil},
            {2, ScrollConstants.fiftyMil},
            {3, ScrollConstants.fiftyMil},
            {4, ScrollConstants.fiftyMil},
            {5, ScrollConstants.fiftyMil},
            {6, ScrollConstants.eightyMil},
            {7, ScrollConstants.eightyMil},
            {8, ScrollConstants.eightyMil},
            {9, ScrollConstants.eightyMil},
            {10, ScrollConstants.eightyMil},
            {11, ScrollConstants.eightyMil},
            {12, ScrollConstants.eightyMil},
            {13, ScrollConstants.eightyMil},
            {14, ScrollConstants.eightyMil},
            {15, ScrollConstants.eightyMil},
            {16, ScrollConstants.eightyMil},
            {17, ScrollConstants.eightyMil},
            {18, ScrollConstants.eightyMil},
            {19, ScrollConstants.eightyMil},
            {20, ScrollConstants.eightyMil}
        };
        public static IReadOnlyDictionary<int, IScrolls> SeventyLevels= new Dictionary<int, IScrolls>()
        {
            {1, ScrollConstants.fiftyMil},
            {2, ScrollConstants.fiftyMil},
            {3, ScrollConstants.fiftyMil},
            {4, ScrollConstants.fiftyMil},
            {5, ScrollConstants.fiftyMil},
            {6, ScrollConstants.eightyMil},
            {7, ScrollConstants.eightyMil},
            {8, ScrollConstants.eightyMil},
            {9, ScrollConstants.eightyMil},
            {10, ScrollConstants.eightyMil},
            {11, ScrollConstants.hundredFortyMil},
            {12, ScrollConstants.hundredFortyMil},
            {13, ScrollConstants.hundredFortyMil},
            {14, ScrollConstants.hundredFortyMil},
            {15, ScrollConstants.hundredFortyMil},
            {16, ScrollConstants.hundredFortyMil},
            {17, ScrollConstants.hundredFortyMil},
            {18, ScrollConstants.hundredFortyMil},
            {19, ScrollConstants.hundredFortyMil},
            {20, ScrollConstants.hundredFortyMil}
        };
        public static IReadOnlyDictionary<int, IScrolls> SeventySevenLevels = new Dictionary<int, IScrolls>()
        {
            {1, ScrollConstants.fiftyMil},
            {2, ScrollConstants.fiftyMil},
            {3, ScrollConstants.fiftyMil},
            {4, ScrollConstants.fiftyMil},
            {5, ScrollConstants.fiftyMil},
            {6, ScrollConstants.eightyMil},
            {7, ScrollConstants.eightyMil},
            {8, ScrollConstants.eightyMil},
            {9, ScrollConstants.eightyMil},
            {10, ScrollConstants.eightyMil},
            {11, ScrollConstants.hundredFortyMil},
            {12, ScrollConstants.hundredFortyMil},
            {13, ScrollConstants.hundredFortyMil},
            {14, ScrollConstants.hundredFortyMil},
            {15, ScrollConstants.hundredFortyMil},
            {16, ScrollConstants.threeHundredMil},
            {17, ScrollConstants.threeHundredMil},
            {18, ScrollConstants.threeHundredMil},
            {19, ScrollConstants.threeHundredMil},
            {20, ScrollConstants.threeHundredMil}
        };
    }
}
