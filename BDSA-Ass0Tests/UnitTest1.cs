using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using ConsoleApp;

namespace BDSA_Ass0.Tests {
    public class UnitTest1 {
        [Theory]
        [InlineData(1804, 1808, 1812, 1816, 1820, 1824, 1824, 1832, 1836, 1840, 1844, 1848, 1852, 1856, 1860, 1864, 1868, 1872, 1876, 1880, 1884, 1888, 1892, 1896, 1904, 1908, 1912, 1916, 1920, 1924, 1928, 1932, 1936, 1940, 1944, 1948, 1952, 1956, 1960, 1964, 1968, 1972, 1976, 1980, 1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092, 2096)]
        public void IsLeapYear_GivenLeapYear_ReturnsTrue(params int[] years) {
            // Act + Assert
            foreach (var ly in years) { 
                Assert.True(ConsoleProgram.IsLeapYear(ly));
            }
        }
        
        [Theory]
        [InlineData(1700, 1800, 1900, 1801, 1909, 2007, 2103)]
        public void IsLeapYear_GivenNotLeapYear_ReturnsFalse(params int[] years) {
            // Act + Assert
            foreach (var ly in years) {
                Assert.False(ConsoleProgram.IsLeapYear(ly));
            }
        }
        
        [Theory]
        [InlineData(1500, -1800, -2007, -2103, 0, -1816, -1836, 1404)]
        public void IsLeapYear_GivenYearOutOfRange_ThrowsArgumentOutOfRangeException(params int[] years) {
            // Act + Assert
            foreach (var year in years) {
                Assert.Throws<ArgumentOutOfRangeException>(()=>ConsoleProgram.IsLeapYear(year));
            }
        }
    }
}