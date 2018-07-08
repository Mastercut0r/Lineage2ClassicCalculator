using EnhancementCalculator.Models;
using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    //https://4gameforum.com/threads/682002/
    public static class InstanceExpPerLevelTable
    {
        public static IReadOnlyDictionary<int, IScrolls> BaiumExpPerLevelTable = new Dictionary<int, IScrolls>()
            {
                {70,  ScrollConstants.hundredMil},
                {71,  ScrollConstants.hundredMil},
                {72,  ScrollConstants.hundredMil},
                {73,  ScrollConstants.hundredMil},
                {74,  ScrollConstants.hundredMil},
                {75,  ScrollConstants.hundredMil},
                {76,  ScrollConstants.twoHundredMil},
                {77,  ScrollConstants.twoHundredMil},
                {78,  ScrollConstants.twoHundredMil},
                {79,  ScrollConstants.twoHundredMil},
                {80,  ScrollConstants.twoHundredMil},
                {81,  ScrollConstants.twoHundredMil},
                {82,  ScrollConstants.twoHundredMil},
                {83,  ScrollConstants.twoHundredMil},
                {84,  ScrollConstants.twoHundredMil}
            };
        public static IReadOnlyDictionary<int, IScrolls> AntharasExpPerLevelTable = new Dictionary<int, IScrolls>()
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
