using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flags
{
    public class FlagsTask
    {
        public static long Solve(int numberOfStripes)
        {
            long baseForOneStripe = 2;
            long baseForTwoStripes = baseForOneStripe;
            if (numberOfStripes == 1 || numberOfStripes == 2)
            {
                return baseForOneStripe;
            }
            var valueOfVarients = new List<long>();
            valueOfVarients.Add(baseForOneStripe);
            valueOfVarients.Add(baseForTwoStripes);

            for (var i = 0; i < numberOfStripes - 2; i++)
            {
                var numberOfVariants = valueOfVarients[i] + valueOfVarients[i + 1];
                valueOfVarients.Add(numberOfVariants);
            }
            return valueOfVarients[valueOfVarients.Count - 1];
        }
    }
}
