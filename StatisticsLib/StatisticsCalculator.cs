using System;
using System.Collections.Generic;
using System.Linq;
namespace StatisticsLib
{
    public static class StatisticsCalculator
    {
        public static double CalculateAverage(List<double> numbers)
        {
            if(numbers.Count==0)return double.NaN;
            return numbers.Average();

        }
        public static double CalculateMinimum(List<double> numbers)
        {
            if(numbers.Count==0)return double.NaN;
            return numbers.Min();

        }
        public static double CalculateMaximum(List<double> numbers)
        {
            if(numbers.Count==0)return double.NaN;
            return numbers.Max();

        }

        public static StatisticsDataHolder CalculateStatistics(List<double> numbers)
        {
            double _maximum=CalculateMaximum(numbers);
            double _minimum=CalculateMinimum(numbers);
            double _average=CalculateAverage(numbers);
            return new StatisticsDataHolder(_minimum,_maximum,_average);

        }
    }
}