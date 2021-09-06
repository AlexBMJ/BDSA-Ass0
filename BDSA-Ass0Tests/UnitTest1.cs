using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using ConsoleApp;

namespace BDSA_Ass0.Tests {
    public class UnitTest1 {
        [Fact]
        public void IsDivisibleByFour() {
            // Arrange
            var program = new ConsoleProgram();
            int[] divisible_by_four = {4, 8, 12, 16, 20, 24,120,124,128,132,400,800,4000,4036};
            // Act
            foreach (var dbf in divisible_by_four) {
                bool prg_result = program.IsDivisibleByFour(dbf);
            // Assert
                Assert.True(prg_result);
            }
        }
        
        [Fact]
        public void IsDivisibleByOneHundred() {
            // Arrange
            var program = new ConsoleProgram();
            int[] divisible_by_onehundred = {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 3000, 6000, 8000};
            // Act
            foreach (var dboh in divisible_by_onehundred) {
                bool prg_result = program.IsDivisibleByOneHundred(dboh);
            // Assert
                Assert.True(prg_result);
            }
        }
        
        [Fact]
        public void IsDivisibleByFourHundred() {
            // Arrange
            var program = new ConsoleProgram();
            int[] divisible_by_fourhundred = {400, 800, 1200, 1600, 2000, 2400, 2800};
            // Act
            foreach (var dbfh in divisible_by_fourhundred) {
                bool prg_result = program.IsDivisibleByFourHundred(dbfh);
            // Assert
                Assert.True(prg_result);
            }
        }
        
        [Fact]
        public void IsLeapYearTest() {
            // Arrange
            var program = new ConsoleProgram();
            int[] leap_years = {1804, 1808, 1812, 1816, 1820, 1824, 1824, 1832, 1836, 1840, 1844, 1848, 1852, 1856, 1860, 1864, 1868, 1872, 1876, 1880, 1884, 1888, 1892, 1896, 1904, 1908, 1912, 1916, 1920, 1924, 1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980, 1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092, 2096};
            // Act + Assert
            foreach (var ly in leap_years) {
                Assert.True(program.IsLeapYear(ly));
            }
        }
        
        [Fact]
        public void IsNotLeapYearTest() {
            // Arrange
            var program = new ConsoleProgram();
            int[] not_leap_years = {1700, 1800, 1900, 1801, 1909, 2007, 2103};
            // Act + Assert
            foreach (var ly in not_leap_years) {
                Assert.False(program.IsLeapYear(ly));
            }
        }

    }
}