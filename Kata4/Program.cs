using System.Linq;
using System;

namespace Kata4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static string HighAndLow(string numbers)
        {
            int[] intArray = numbers.Split(" ").Select(int.Parse).ToArray();

            int highest = Convert.ToInt32(intArray.Max());
            int lowest = Convert.ToInt32(intArray.Min());

            return String.Join(" ", highest, lowest);
        }
    }
}
