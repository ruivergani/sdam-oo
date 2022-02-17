using System.Collections.Generic;

namespace Average_WithObjects
{
    class AverageCalculator
    {

        public double CalculateAverage(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0;
            }

            int sum = 0;
            numbers.ForEach(i => sum += i);

            return (double)sum / numbers.Count;
        }
    }
}
