using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_Acceleration_Program_.Net_II_Step
{
    public class InternTasks
    {
        //არის თუ არა ტექსტი პალინდრომი
        /// <summary>
        /// Checks if specific string is Palindrome or not.
        /// </summary>
        /// <param name="s">String you want to check.</param>
        /// <returns>Boolean value.</returns>
        public bool IsPalindrome(string s)
        {
            //1st method
            //Reversing the string
            //string reverse = "";
            //for (int j = s.Length - 1; j >= 0; j--)
            //{
            //    reverse += s[j];
            //}
            //checking if Reversed string is same as the original and returning boolean value.
            //return reverse == s;

            //2nd method.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }
        //აბრუნებს მონეტების მინიმალურ რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ
        /// <summary>
        /// Returns the minimal amount of coins for specific amount of Tetri.
        /// </summary>
        /// <param name="amount">Amount of Tetri</param>
        /// <returns>Amount of coins</returns>
        public int MinSplit(int amount)
        {
            //Instead of using loops we can use this method.
            //1 5 10 20 50
            int x = amount / 50;
            amount -= x * 50;
            int y = amount / 20;
            amount -= y * 20;
            int z = amount / 10;
            amount -= z * 10;
            int m = amount / 5;
            amount -= m * 5;
            int n = amount;
            amount -= n * 1;
            return x + y + z + m + n;
        }
        //აბრუნებს მინიმალურ მთელ რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.
        /// <summary>
        /// Returns the minimal number which is not in array.
        /// </summary>
        /// <param name="array">array of numbers</param>
        /// <returns>intiger which isn't contained in array</returns>
        public int NotContains(int[] array)
        {
            //count is not 0
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                //if count can't be less than specific value, let it be 1 unit greater.
                if (array[i] <= count)
                {
                    count = array[i] + 1;
                }
            }
            return count;
        }
    }
}
