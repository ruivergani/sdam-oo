using System.Collections.Generic;

namespace Average_WithDataInObjects
{
    class AverageCalculator
    {

        private List<int> numbers;

        public AverageCalculator(List<int> nums)
        {
            this.numbers = nums;
        }

        public void AddIntegers(List<int> nums)
        {
            this.numbers.AddRange(nums);
        }

        public double CalculateAverage()
        {
            if (numbers.Count == 0)
            {
                return 0;
            }

            int sum = 0;
            numbers.ForEach(i => sum += i);

            return (double)sum / numbers.Count;
        }

        public List<int> GetCopyOfNumbers()
        {
            return new List<int>(numbers);
        }
    }
}
