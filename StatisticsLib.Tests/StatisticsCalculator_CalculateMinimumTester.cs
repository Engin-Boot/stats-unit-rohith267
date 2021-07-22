using System;
using Xunit;
using StatisticsLib;
using System.Collections.Generic;

namespace StatisticsLib.Tests
{
    public class StatisticsCalculator_CalculateMinimumTester
    {
        [Fact]
        public void CalculateMinimum_GivenNonEmptyList_ReportsMinimum()
        {
            var computedMin = StatisticsCalculator.CalculateMinimum(new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedMin - 1.5) <= epsilon);

        }
        [Fact]
        public void CalculateMinimum_GivenEmptyList_ReportsNaN()
        {
            var computedMin=StatisticsCalculator.CalculateMinimum(new List<double> {});
            Assert.True(double.IsNaN(computedMin));
            
            
       
        }
    }
}
