using System;

namespace ConsoleApp {
    public class ConsoleProgram {
        public static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
        public bool IsLeapYear(int year) {
            if (year < 1582)
                throw new ArgumentOutOfRangeException();
            return ((IsDivisibleBy(4, year) && !IsDivisibleBy(100, year)) || IsDivisibleBy(400, year));
        }

        private bool IsDivisibleBy(int divisor, int num) {
            return (num % divisor) == 0;
        }
    }
}