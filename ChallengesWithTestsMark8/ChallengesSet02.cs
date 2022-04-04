using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            if (letters.Contains(char.ToLower(c)))
            {
                return true;
            }
            else { 
                return false;
            }
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if ((vals.Length) % 2 == 0)
            {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) {
                return 0;
            }

            int count = 0;
            double min = 0;
            double max = 0;
            foreach (double number in numbers) {
                if (count == 0) {
                    min = number;
                    max = number;
                }
                if (number < min) {
                    min = number;
                }
                if (number > max) {
                    max = number;
                }
                count++;
            }

            return min + max;
            
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else { 
                return str2.Length;
            }
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if(numbers==null){
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++) {
                sum+=numbers[i];
            }
            return sum;
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] % 2 == 0) {
                    sum+=numbers[i];
                }
            }
            return sum;
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++) {
                sum += numbers[i];
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
            if (number == 0) {
                return 0;
            }
            for (int i = 0; i < number; i++) {
                if (i % 2 != 0) {
                    count++;
                }
            }

            return count;
            throw new NotImplementedException();
        }
    }
}
