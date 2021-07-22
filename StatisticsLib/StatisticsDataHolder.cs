using System;
using System.Collections.Generic;
using System.Text;
namespace StatisticsLib
{
    public class StatisticsDataHolder{
        public double minimum;
        public double maximum;
        public double average;
        public StatisticsDataHolder(double _minimum, double _maximum , double _average )
        {
            this.minimum = _minimum;
            this.maximum = _maximum;
            this.average = _average;
        }
    }

}