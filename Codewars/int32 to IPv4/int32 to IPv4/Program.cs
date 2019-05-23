using System;
using System.Net;

namespace int32_to_IPv4
{
    class Program
    {
        public static string UInt32ToIP(uint ip)
        {
            return IPAddress.Parse(ip.ToString()).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input int32 value:");
            uint ip = uint.Parse(Console.ReadLine());
            Console.WriteLine(UInt32ToIP(ip));
            Console.ReadKey();
        }
    }
}
