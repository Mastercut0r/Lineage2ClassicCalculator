using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    public static class ExperienceForLevelTable
    {
        public static IEnumerable<int> LevelRanges => ExperienceForLevel.Keys;
        public static IReadOnlyDictionary<int, ulong> ExperienceForLevel = new Dictionary<int, ulong>()
        {
               {40,  8551061},
               {41,  9846126},
               {42,  11316878},
               {43,  12982465},
               {44,  14867867},
               {45,  17000993},
               {46,  19407889},
               {47,  22121973},
               {48,  25180293},
               {49,  28620702},
               {50,  32487761},
               {51,  36830535},
               {52,  41702939},
               {53,  47168178},
               {54,  53283060},
               {55,  60126717},
               {56,  67777087},
               {57,  76324226},
               {58,  85861254},
               {59,  96500949},
               {60,  108361016},
               {61,  121569674},
               {62,  136266340},
               {63,  152609718},
               {64,  170780591},
               {65,  190968478},
               {66,  213370544},
               {67,  238226785},
               {68,  265789703},
               {69,  296323272},
               {70,  330154725},
               {71,  367597290},
               {72,  409022986},
               {73,  454835707},
               {74,  505473160},
               {75,  561422356},
               {76,  623182525},
               {77,  1175470061},
               {78,  2233393116},
               {79,  6700179347},
               {80,  22333931158}
        };
        public static bool IsLevelUpPossible(int currentLevel)
        {
            return ExperienceForLevel.ContainsKey(currentLevel+1);
        }
    }
}

