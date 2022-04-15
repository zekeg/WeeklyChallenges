using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals) {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum=0;
            if (numbers == null) { 
                return false;
            }
            foreach (var num in numbers) {
                if (num % 2 != 0) {
                    sum += num;
                }
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

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper=false;
            bool containsLower=false;
            bool containsNumber=false;

            if (password == null) {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i])) {
                    containsUpper = true;
                }
                if (Char.IsLower(password[i])) {
                    containsLower = true;
                }
                if (Char.IsDigit(password[i]) == true) {
                    containsNumber = true;
                }
            }
            if (containsUpper == true && containsLower == true && containsNumber == true)
            {
                return true;
            }
            else {
                return false;
            }
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            return dividend / divisor;
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            if(nums== null) { return 0; }
            return nums[nums.Length - 1] - nums[0];
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 100; i++) {
                if (i % 2 != 0) {
                    nums.Add(i);
                }
            }
            return nums.ToArray();
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
