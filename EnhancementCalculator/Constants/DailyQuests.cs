using EnhancementCalculator.Models;

namespace EnhancementCalculator.Constants
{
    //Table:
    //https://l2central.info/classic/%D0%95%D0%B6%D0%B5%D0%B4%D0%BD%D0%B5%D0%B2%D0%BD%D1%8B%D0%B5_%D0%B7%D0%B0%D0%B4%D0%B0%D0%BD%D0%B8%D1%8F
    static class DailyQuests
    {
        static IScrolls Reward(int level, int questAmmountPerWeek = 7)
        {
            if (level < 46)
            {
                return new DailyScrolls(3, questAmmountPerWeek);
            }
            if (level < 55)
            {
                return new DailyScrolls(7, questAmmountPerWeek);
            }
            if (level < 65)
            {
                return new DailyScrolls(9, questAmmountPerWeek);
            }
            if (level < 76)
            {
                return new DailyScrolls(11, questAmmountPerWeek);
            }
            if (level >= 76)
            {
                return new DailyScrolls(30, questAmmountPerWeek);
            }
            else return new DailyScrolls(0, questAmmountPerWeek);
        }
    }
}
