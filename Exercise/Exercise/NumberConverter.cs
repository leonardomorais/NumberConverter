using System.Collections.Generic;

namespace Exercise
{
    public class NumberConverter
    {
        private readonly Dictionary<char, int> values = new Dictionary<char, int>
        {
            { 'I', 1 },  { 'V', 5 },  { 'X', 10 },  { 'L', 50 },
            { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };

        public int ConvertToNumber(string romanNumber)
        {
            int arabicNumber = 0;
            int limit = romanNumber.Length - 1;

            for (int index = 0; index <= limit; index++)
            {
                var number = romanNumber[index];
                int value = values[number];

                if (index == limit)
                    return arabicNumber + value;

                char romanNextIndex = romanNumber[index + 1];
                int nextValue = values[romanNextIndex];

                if (value < nextValue)
                {
                    arabicNumber += nextValue - value;
                    index++;
                    continue;
                }

                arabicNumber += value;
            }

            return arabicNumber;
        }
    }
}
