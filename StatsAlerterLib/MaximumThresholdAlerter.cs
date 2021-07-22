using System;
using AlertsLib;
using StatisticsLib;
using System.Collections.Generic;
namespace StatsAlerterLib
{
    public class MaximumThresholdAlerter
    {
        double maxThreshold;
        List<IAlerter> alerter_list=new List<IAlerter>();
        public MaximumThresholdAlerter(List<IAlerter> alerters,double maxThreshold)
        {
            for(int alerter_number=0;alerter_number<alerters.Count;alerter_number++)
            {
                this.alerter_list.Add(alerters[alerter_number]);
            }
            this.maxThreshold=maxThreshold;

        }
        public void CheckMaxAndAlert(List<double> numbers)
        {
            double maximum=StatisticsCalculator.CalculateMaximum(numbers);
            if(!double.IsNaN(maximum))
            {
                for(int alerter_number=0;alerter_number<alerter_list.Count;alerter_number++)
                {
                    alerter_list[alerter_number].Alert(maxThreshold,maximum);
                }
            }

        }


    }
}
