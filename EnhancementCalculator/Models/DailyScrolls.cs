using EnhancementCalculator.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementCalculator.Models
{
    class DailyScrolls : IScrolls
    {
        public int TenKkScrollCount { get; private set; }

        public int FiftyKkScrollCount { get; private set; }

        public int HundredKkScrollCount { get; private set; }

        public ulong TotalExp { get; private set; }

        public ulong TotalMoney { get; private set; }

        public DailyScrolls(int millExpCount, int questPerWeekCount)
        {
            TotalExp = CalculateTotalExp(millExpCount, questPerWeekCount);
        }

        private ulong CalculateTotalExp(int millExpCount, int questPerWeekCount)
        {
            return (uint)millExpCount * (uint)questPerWeekCount * ScrollConstants.millExp;
        }
    }
}
