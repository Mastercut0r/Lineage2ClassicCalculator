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
            {20, ScrollConstants.eightyMil},
            {21, ScrollConstants.eightyMil},
            {22, ScrollConstants.eightyMil},
            {23, ScrollConstants.eightyMil},
            {24, ScrollConstants.eightyMil},
            {25, ScrollConstants.eightyMil}
        };
        public static IReadOnlyDictionary<int, IScrolls> SeventyLevels= new Dictionary<int, IScrolls>()
        {
            {1, ScrollConstants.fiftyMil},
            {2, ScrollConstants.fiftyMil},
            {3, ScrollConstants.fiftyMil},
            {4, ScrollConstants.fiftyMil},
            {5, ScrollConstants.fiftyMil},
            {6, ScrollConstants.hundredMil},
            {7, ScrollConstants.hundredMil},
            {8, ScrollConstants.hundredMil},
            {9, ScrollConstants.hundredMil},
            {10, ScrollConstants.hundredMil},
            {11, ScrollConstants.hundredFortyMil},
            {12, ScrollConstants.hundredFortyMil},
            {13, ScrollConstants.hundredFortyMil},
            {14, ScrollConstants.hundredFortyMil},
            {15, ScrollConstants.hundredFortyMil},
            {16, ScrollConstants.hundredFortyMil},
            {17, ScrollConstants.hundredFortyMil},
            {18, ScrollConstants.hundredFortyMil},
            {19, ScrollConstants.hundredFortyMil},
            {20, ScrollConstants.hundredFortyMil},
            {21, ScrollConstants.hundredFortyMil},
            {22, ScrollConstants.hundredFortyMil},
            {23, ScrollConstants.hundredFortyMil},
            {24, ScrollConstants.hundredFortyMil},
            {25, ScrollConstants.hundredFortyMil}

        };
        public static IReadOnlyDictionary<int, IScrolls> SeventySevenLevels = new Dictionary<int, IScrolls>()
        {
            {1, ScrollConstants.fiftyMil},
            {2, ScrollConstants.fiftyMil},
            {3, ScrollConstants.fiftyMil},
            {4, ScrollConstants.fiftyMil},
            {5, ScrollConstants.fiftyMil},
            {6, ScrollConstants.hundredMil},
            {7, ScrollConstants.hundredMil},
            {8, ScrollConstants.hundredMil},
            {9, ScrollConstants.hundredMil},
            {10, ScrollConstants.hundredMil},
            {11, ScrollConstants.hundredFortyMil},
            {12, ScrollConstants.hundredFortyMil},
            {13, ScrollConstants.hundredFortyMil},
            {14, ScrollConstants.hundredFortyMil},
            {15, ScrollConstants.hundredFortyMil},
            {16, ScrollConstants.threeHundredMil},
            {17, ScrollConstants.threeHundredMil},
            {18, ScrollConstants.threeHundredMil},
            {19, ScrollConstants.threeHundredMil},
            {20, ScrollConstants.threeHundredMil},
            {21, ScrollConstants.threeHundredMil},
            {22, ScrollConstants.threeHundredMil},
            {23, ScrollConstants.threeHundredMil},
            {24, ScrollConstants.threeHundredMil},
            {25, ScrollConstants.threeHundredMil}

        };
        public static IReadOnlyDictionary<int, IScrolls> SeventyEightLevels = new Dictionary<int, IScrolls>()
        {
            {1, ScrollConstants.eightyMil},
            {2, ScrollConstants.eightyMil},
            {3, ScrollConstants.eightyMil},
            {4, ScrollConstants.eightyMil},
            {5, ScrollConstants.eightyMil},
            {6, ScrollConstants.hundredTwentyMil},
            {7, ScrollConstants.hundredTwentyMil},
            {8, ScrollConstants.hundredTwentyMil},
            {9, ScrollConstants.hundredTwentyMil},
            {10, ScrollConstants.hundredTwentyMil},
            {11, ScrollConstants.twoHundredMil},
            {12, ScrollConstants.twoHundredMil},
            {13, ScrollConstants.twoHundredMil},
            {14, ScrollConstants.twoHundredMil},
            {15, ScrollConstants.twoHundredMil},
            {16, ScrollConstants.threeHundredFiftyMil},
            {17, ScrollConstants.threeHundredFiftyMil},
            {18, ScrollConstants.threeHundredFiftyMil},
            {19, ScrollConstants.threeHundredFiftyMil},
            {20, ScrollConstants.threeHundredFiftyMil},
            {21, ScrollConstants.sixHundredMil},
            {22, ScrollConstants.sixHundredMil},
            {23, ScrollConstants.sixHundredMil},
            {24, ScrollConstants.sixHundredMil},
            {25, ScrollConstants.sixHundredMil}
        };

    }
}
