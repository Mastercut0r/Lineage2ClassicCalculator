using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    //https://4gameforum.com/threads/682002/
    public static class InstanceExpPerLevelTable
    {
        public static IReadOnlyDictionary<int, IScrolls> BaiumExpPerLevelTable = new Dictionary<int, IScrolls>()
            {
                {70,  ScrollConstants.twoHundredMil},
                {71,  ScrollConstants.twoHundredMil},
                {72,  ScrollConstants.twoHundredMil},
                {73,  ScrollConstants.twoHundredMil},
                {74,  ScrollConstants.twoHundredMil},
                {75,  ScrollConstants.twoHundredMil},
                {76,  ScrollConstants.threeHundredMil},
                {77,  ScrollConstants.threeHundredMil},
                {78,  ScrollConstants.threeHundredMil},
                {79,  ScrollConstants.threeHundredMil},
                {80,  ScrollConstants.threeHundredMil},
                {81,  ScrollConstants.threeHundredMil},
                {82,  ScrollConstants.threeHundredMil},
                {83,  ScrollConstants.threeHundredMil},
                {84,  ScrollConstants.threeHundredMil}
            };
        public static IReadOnlyDictionary<int, IScrolls> AntharasExpPerLevelTable = new Dictionary<int, IScrolls>()
            {
                {70,  ScrollConstants.twoHundredMil},
                {71,  ScrollConstants.twoHundredMil},
                {72,  ScrollConstants.twoHundredMil},
                {73,  ScrollConstants.twoHundredMil},
                {74,  ScrollConstants.twoHundredMil},
                {75,  ScrollConstants.twoHundredMil},
                {76,  ScrollConstants.fourHundredMil},
                {77,  ScrollConstants.fourHundredMil},
                {78,  ScrollConstants.fourHundredMil},
                {79,  ScrollConstants.fourHundredMil},
                {80,  ScrollConstants.fourHundredMil},
                {81,  ScrollConstants.fourHundredMil},
                {82,  ScrollConstants.fourHundredMil},
                {83,  ScrollConstants.fourHundredMil},
                {84,  ScrollConstants.fourHundredMil}
            };
        public static IReadOnlyDictionary<int, IScrolls> ZakenExpPerLevelTable = new Dictionary<int, IScrolls>()
            {
                {70,  ScrollConstants.hundredMil},
                {71,  ScrollConstants.hundredMil},
                {72,  ScrollConstants.hundredMil},
                {73,  ScrollConstants.hundredMil},
                {74,  ScrollConstants.hundredMil},
                {75,  ScrollConstants.hundredMil},
                {76,  ScrollConstants.threeHundredMil},
                {77,  ScrollConstants.threeHundredMil},
                {78,  ScrollConstants.threeHundredMil},
                {79,  ScrollConstants.threeHundredMil},
                {80,  ScrollConstants.threeHundredMil},
                {81,  ScrollConstants.threeHundredMil},
                {82,  ScrollConstants.threeHundredMil},
                {83,  ScrollConstants.threeHundredMil},
                {84,  ScrollConstants.threeHundredMil}
            };

    }
}
