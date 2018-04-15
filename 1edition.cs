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
            {
                return firstPart;
            }
            var valueOfVarients = new List<long>();
            valueOfVarients.Add(firstPart);
            valueOfVarients.Add(firstPart);

            for (var i = 0; i < numberOfStripes - 2; i++)
            {
                var numberOfVariants = valueOfVarients[i] + valueOfVarients[i + 1];
                valueOfVarients.Add(numberOfVariants);
            }
            return valueOfVarients[valueOfVarients.Count - 1];
        }
    }
}
