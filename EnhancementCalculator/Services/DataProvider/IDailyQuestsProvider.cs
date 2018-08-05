using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services
{
    public interface IDailyQuestsProvider
    {
        IScrolls WeeklyReward(int level, int questAmmountPerWeek = 7);
        IScrolls DailyReward(int level);
    }
}
