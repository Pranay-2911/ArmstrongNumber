using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.Models
{
    internal class CheckingArmstrong
    {
        const int divisor = 10;  // Varible contain divisor value
        const int minValue = 0;  // Varible contain min Value for the while loops
        public static string ToCheckArmstrong(int number)
        {
            int tempNumber = number;
            int power = CountDigits(number);   // Contain the count of digit to calculate the power 
            int result = 0;


            //Calculate the power of each digits and add the in the result varible
            while (tempNumber > minValue)
            {
                int temp = tempNumber % divisor;
                result += (int)Math.Pow(temp, power);
                tempNumber /= divisor;
            }


            // Returning the final answer
            if (result == number)
            {
                return $"The number {number} is an Armstrong number.";
            }

            return $"The number {number} is an Not an Armstrong number.";
        }


        // Calculate the count of the digit
        static int CountDigits(int number)
        {
            int count = 0;

            while(number > minValue)
            {
                number = number / divisor;
                count++;
            }
            return count;
        }
    }
}
