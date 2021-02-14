using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTenPops
{
    class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
            {
                return "(Unknown)";
            }

            int popRounded = RoundPopulation4(population);

            return $"{popRounded: ###,###,###,###}".Trim(); 
        }


        //Round population to 4 significant figures
        private static int RoundPopulation4(int population)
        {
            // work out what rounding accuracy we need if we are to round to 4 significant figures
            int accuracy = Math.Max( (int) (GetHighestPowerofTen(population) / 10_000l), 1);

            // now do the rounding
            return RoundToNearest(population, accuracy);
        }

        /// <summary>
        /// Rounds the number to the specified accuracy
        /// For example, if the accuracy is 10, then we round to the nearest 10:
        /// 23 -> 20
        /// 25 -> 30
        /// etc.
        /// </summary>
        /// <param name="exact"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        private static int RoundToNearest(int population, int accuracy)
        {
            int adjusted = population + accuracy / 2;
            return adjusted - adjusted % accuracy;
        }

        /// <summary>
        /// Returns the highest number that is a power of 10 and is no larger than the number supplied
        /// Examples:
        /// GetHighestPowerOfTen(11) = 10
        /// GetHighestPowerOfTen(99) = 10
        /// GetHighestPowerOfTen(100) = 100
        /// GetHighestPowerOfTen(843) = 100
        /// GetHighestPowerOfTen(1000) = 1000
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        private static long GetHighestPowerofTen(int population)
        {
            long result = 1;
            while ( population > 0)
            {
                population /= 10;
                result *= 10;
            }
            return result;
        }
    }
}
