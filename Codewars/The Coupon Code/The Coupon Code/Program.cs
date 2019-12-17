using System;
using System.Collections.Generic;

namespace The_Coupon_Code
{
    class Program
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            DateTime today = DateTime.Parse(currentDate);
            DateTime couponEnds = DateTime.Parse(expirationDate);
            if (enteredCode != correctCode)
                return false;
            if (today > couponEnds)
                return false;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter valid coupon information");
            Console.WriteLine("Enter code");
            string enteredCode = Console.ReadLine();
            Console.WriteLine("Enter correct code");
            string correctCode = Console.ReadLine();
            Console.WriteLine("Enter current date");
            DateTime currentDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter expiration date");
            DateTime expirationDate = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            List<string> coupon = new List<string>();
            coupon.Add(enteredCode);
            coupon.Add(correctCode);
            coupon.Add(currentDate.ToString());
            coupon.Add(expirationDate.ToString());
            //Console.WriteLine(string.Join(" , ", coupon));
            Console.WriteLine(CheckCoupon(enteredCode, correctCode, currentDate.ToString(), expirationDate.ToString()));
            Console.ReadKey();
        }
    }
}
