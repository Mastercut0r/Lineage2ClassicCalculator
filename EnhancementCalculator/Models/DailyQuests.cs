using EnhancementCalculator.Models;

namespace EnhancementCalculator.Models
{
    //Table:
    //https://l2central.info/classic/%D0%95%D0%B6%D0%B5%D0%B4%D0%BD%D0%B5%D0%B2%D0%BD%D1%8B%D0%B5_%D0%B7%D0%B0%D0%B4%D0%B0%D0%BD%D0%B8%D1%8F
    class DailyQuests : IDailyQuests
    {
        public IScrolls WeeklyReward(int level, int questAmmountPerWeek = 7)
        {
            if (level < 46)
            {
                return new Scrolls(3 * questAmmountPerWeek, 0);
            }
            if (level < 55)
            {
                return new Scrolls(7 * questAmmountPerWeek, 0);
            }
            if (level < 65)
            {
                return new Scrolls(9 * questAmmountPerWeek, 0);
            }
            if (level < 76)
            {
                return new Scrolls(11 * questAmmountPerWeek, 0);
            }
            if (level >= 76)
            {
                return new Scrolls(0, 3 * questAmmountPerWeek);
            }
            else return new Scrolls(0, 0);
        }
    }
}
