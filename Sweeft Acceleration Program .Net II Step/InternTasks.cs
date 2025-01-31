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
            //sort the array
            Array.Sort(array);
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

        //აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად სწორად დასმული.
        /// <summary>
        /// Checks if sequence of parentheses is properly.
        /// </summary>
        /// <param name="sequence">text where we check parentheses</param>
        /// <returns>boolean value.</returns>
        public bool IsProperly(string sequence)
        {
            int open = 0, close = 0;
            foreach (var cr in sequence)
            {
                //checks if closeing is before opening
                if (close > open) { return false; }
                //counts amount of closings and openings
                if (cr == '(') { open++; }
                if (cr == ')') { close++; }
            }
            if (open != close) { return false; }
            return true;
        }

        //დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.
        /// <summary>
        /// Returns the amount of ways to go up n stairs.
        /// </summary>
        /// <param name="stairCount">stairs count</param>
        /// <returns>varaints count</returns>
        public int CountVariants(int stairCount)
        {
            //method 1 (recursion)
            ////ერთი ნაბიჯი = n-1
            ////ორი ნაბიჯი = n-2

            ////if its either 1 or 2, there is 1 or 2 variants of going up.
            //if (stairCount == 1) return 1;
            //if (stairCount == 2) return 2;
            ////f(n) = f(n-1) + f(n-2)
            //return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);

            //method 2 (dynamic)
            if (stairCount == 1) return 1;
            if (stairCount == 2) return 2;
            //f(n) = f(n-1) + f(n-2):
            int pre = 1; // f(1)
            int pre2 = 2; // f(2)
            int variants = 0; //f(n)
            //ვიწიყებთ i = 3 რადგან 1 და 2 უკვე წინასწარ განსაზღვრულია.
            for (int i = 3; i <= stairCount; i++)
            {
                //f(n) = f(n-1) + f(n-2):
                variants = pre + pre2;
                pre = pre2;
                pre2 = variants;
            }
            return variants;
        }

    }
}
