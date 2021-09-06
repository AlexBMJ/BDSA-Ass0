using System;

namespace ConsoleApp {
    public class ConsoleProgram {
        public static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
        public bool IsLeapYear(int year) {
            return ((IsDivisibleByFour(year) && !IsDivisibleByOneHundred(year)) || IsDivisibleByFourHundred(year));
        }

        public bool IsDivisibleByFour(int num) {
            return (num % 4) == 0;
        }
        public bool IsDivisibleByOneHundred(int num) {
            return (num % 100) == 0;
        }

        public bool IsDivisibleByFourHundred(int num) {
            return (num % 400) == 0;
        }
    }
}