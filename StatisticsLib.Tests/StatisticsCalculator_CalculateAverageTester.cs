using System;
using Xunit;
using StatisticsLib;
using System.Collections.Generic;

namespace StatisticsLib.Tests
{
    public class StatisticsCalculator_CalculateAverageTester
    {
        [Fact]
        public void CalculateAverage_GivenNonEmptyList_ReportsAverage()
        {
            var computedAvg = StatisticsCalculator.CalculateAverage(new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedAvg - 4.525) <= epsilon);

        }
        [Fact]
        public void CalculateAverage_GivenEmptyList_ReportsNaN()
        {
            var computedAvg=StatisticsCalculator.CalculateAverage(new List<double> {});
            Assert.True(double.IsNaN(computedAvg));
            
            
       
        }
    }
}
