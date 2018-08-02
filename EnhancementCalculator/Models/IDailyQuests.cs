using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementCalculator.Models
{
    public interface IDailyQuestsProvider
    {
        IScrolls WeeklyReward(int level, int questAmmountPerWeek = 7);
        IScrolls DailyReward(int level);
    }
}
