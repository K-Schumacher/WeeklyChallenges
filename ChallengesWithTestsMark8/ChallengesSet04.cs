using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var num = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    num += number;
                }
                else
                {
                    num -= number;
                }
            }
            return num;
        } 

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var round1 = str1.Length < str2.Length ? str1.Length : str2.Length;
            var round2 = str3.Length < str4.Length ? str3.Length : str4.Length;
            var shortest = round1 < round2 ? round1 : round2;

            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int round1 = number1 < number2 ? number1 : number2;
            int round2 = number3 < number4 ? number3 : number4;
            int smallestNumber = round1 < round2 ? round1 : round2;

            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            double num = 0;
            var result = double.TryParse(input, out num);

            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = new List<object>();
            var notNull = new List<object>();

            foreach (var objects in objs)
            {
                if (objects == null)
                {
                    nulls.Add(objects);
                }
                else
                {
                    notNull.Add(objects);
                }

            }
                if (nulls.Count() > notNull.Count())
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public double AverageEvens(int[] numbers)
        {
            //determine average number by sum of evens / by length
            //newArray.Sum() / newArray.Length;
            //recognize even by num % 2 == 0 

            //test requires null check
            if (numbers == null)
            {
                return 0;
            }

            //create variables for sum (all of the elements in array)
            //example: 1, 2, 4, 5, 6, 8, 4
            //sum evens is = 24
            //counter = 5
            //24 / 5 = 4.8
            double sum = 0;
            double counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                //locate even numbers in array
                if (numbers[i] % 2 == 0)
                {
                    //total elements in array incremented
                    counter++;
                    //sum here are the even numbers in the array summed up
                    sum += numbers[i];
                }
            }
            //need to check for sum being 0, this includes empty array and only odd nums in array
            if (sum == 0)
            {
                return 0;
            }
            //once it goes thru the if statement in the for loop to locate the evens 
            //it takes sum of all evens and divides it by the counter (total elements think of counter as 'count')
            return sum / counter;

            /*
            var numbersList = new List<int>();

            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (var number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        numbersList.Add(number);
                    }
                }
                var avg = numbersList.Average();
                return avg;
            }
        */
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
