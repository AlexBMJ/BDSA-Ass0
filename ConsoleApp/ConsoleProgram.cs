using System;

namespace ConsoleApp {
    public class ConsoleProgram {
        public static void Main(string[] args) {
            while (true) {
                try {
                    Console.WriteLine(IsLeapYear(Convert.ToInt32(Console.ReadLine())) ? "yay" : "nay");
                }
                catch (Exception e) when (e is FormatException | e is OverflowException | e is ArgumentOutOfRangeException) {
                    Console.WriteLine("Input must be a valid year after 1512");
                }
            }
        }
        public static bool IsLeapYear(int year) {
            if (year < 1582)
                throw new ArgumentOutOfRangeException();
            return ((IsDivisibleBy(4, year) && !IsDivisibleBy(100, year)) || IsDivisibleBy(400, year));
        }

        private static bool IsDivisibleBy(int divisor, int num) {
            return (num % divisor) == 0;
        }
    }
}