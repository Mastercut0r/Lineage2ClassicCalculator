using EnhancementCalculator.Constants;

namespace EnhancementCalculator.Models
{
    class ClanArena : IClanArena
    {
        public IScrolls Reward(int characterLevel, int bossStage)
        {
            if (characterLevel <= 49)
            {
                return ArenaRewardPerLevelRange.FortyLevels;
            }
            else if (characterLevel <= 59)
            {
                return ArenaRewardPerLevelRange.FiftyLevels;
            }
            else if (characterLevel <= 69)
            {
                return ArenaRewardPerLevelRange.SixtyLevels[bossStage];
            }
            else if (characterLevel <= 76)
            {
                return ArenaRewardPerLevelRange.SeventyLevels[bossStage];
            }
            else if (characterLevel == 77)
            {
                return ArenaRewardPerLevelRange.SeventySevenLevels[bossStage];
            }
            else if(characterLevel <= 85)
            {
                return ArenaRewardPerLevelRange.SeventyEightLevels[bossStage];
            }
            else return null;
        }

        public IScrolls Reward(int characterLevel, int startStage, int endStage)
        {
            var scrolls = Scrolls.CreateEmptyContainer();
            for (int stage = startStage; stage <= endStage; stage++)
            {
                scrolls = (Scrolls)scrolls + (Scrolls)Reward(characterLevel, stage);
            }
            return scrolls;
        }
    }
}
