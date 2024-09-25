using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber.Models
{
    internal class CheckingArmstrong
    {
        public static bool ToCheckArmstrong(int number)
        {
            int tempNumber = number;
            int power = number.ToString().Length;
            int result = 0;

            while (tempNumber > 0)
            {
                int temp = tempNumber % 10;
                result += (int)Math.Pow(temp, power);
                tempNumber /= 10;
            }

            if (result == number) return true;

            return false;
        }
    }
}
