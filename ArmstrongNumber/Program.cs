using ArmstrongNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CheckingArmstrong.ToCheckArmstrong(number));
               
        }
    }
}
