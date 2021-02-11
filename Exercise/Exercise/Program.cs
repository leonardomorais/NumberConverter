using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class NumberConverter
    {
        private readonly Dictionary<char, int> values = new Dictionary<char, int>
        {
            { 'I', 1 },  { 'V', 5 },  { 'X', 10 },  { 'L', 50 },
            { 'C', 100 }, { 'D', 500 }, { 'M', 100 }
        };

        public int ConvertToNumber(string romanNumber)
        {
            int arabicNumber = 0;
            
            for (int index = 0; index < romanNumber.Length; index++)
            {
                var number = romanNumber[index];
                if (index == 0)
                {
                    arabicNumber = values[number];
                    continue;
                }

                int value = values[number];
                char previous = romanNumber[index - 1];
                int previousValue = values[previous];

                arabicNumber = previousValue < value ? value - previousValue : arabicNumber + value;
            }

            return arabicNumber;
        }
    }
}
