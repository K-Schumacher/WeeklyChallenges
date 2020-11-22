using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for ( var i = 0; i < vals.Length; i++)
            {
                if (!vals[i]) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddCount = 0;
            if (numbers == null) { return false; }
            foreach (var num in numbers)
            {
                if (num % 2 != 0) { oddCount += num; }
            }
            return (oddCount % 2 == 0) ? false : true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums.Last();
            var first = nums.First();

            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var oddsList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsList.Add(i);
                }
            }


            return oddsList.ToArray();

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
