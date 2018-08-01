using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnhancementCalculator.Models;

namespace EnhancementCalculator.Services.Strategies
{
    class Zaken : IStrategy
    {
        public (bool levelIncreased, int currentLevel, IScrolls collectedScrolls) Apply(int currentLevel, IScrolls collectedScrolls)
        {
            throw new NotImplementedException();
        }
    }
}
