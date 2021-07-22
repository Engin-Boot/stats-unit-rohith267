using System;
using Xunit;
using StatisticsLib;
using System.Collections.Generic;

namespace StatisticsLib.Tests
{
    public class MaximumTester
    {
        [Fact]
        public void CalculateMaximum_GivenNonEmptyList_ReportsMinimum()
        {
            var computedMax = StatisticsCalculator.CalculateMaximum(new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedMax - 8.9) <= epsilon);

        }
        [Fact]
        public void CalculateMaximum_GivenEmptyList_ReportsNaN()
        {
            var computedMax=StatisticsCalculator.CalculateMaximum(new List<double> {});
            Assert.True(double.IsNaN(computedMax));
            
            
       
        }
    }
}
