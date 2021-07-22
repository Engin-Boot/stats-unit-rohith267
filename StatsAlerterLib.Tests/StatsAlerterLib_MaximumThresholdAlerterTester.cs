using System;
using Xunit;
using StatisticsLib;
using StatsAlerterLib;
using AlertsLib;
using System.Collections.Generic;

namespace StatsAlerterLib.Tests
{
    public class StatsAlerterLib_MaximumThresholdAlerterTester
    {
        [Fact]
        public void RaisesAlertIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LEDAlert();
            IAlerter[] alerters = { emailAlert, ledAlert };
            List<IAlerter> alertersList = new List<IAlerter>(alerters);
            const double maxThreshold = 10.2;
            var _maximumThresholdAlerter = new MaximumThresholdAlerter( alertersList,maxThreshold);
            _maximumThresholdAlerter.CheckMaxAndAlert(new List<double> { 0.2, 11.9, 4.3, 8.5 });

            Assert.True(emailAlert.emailSent);
            Assert.True(ledAlert.ledGlown);


        }
        [Fact]
        public void DoesnotRaiseAlertIfListIsEmpty()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LEDAlert();
            IAlerter[] alerters = { emailAlert, ledAlert };
            List<IAlerter> alertersList = new List<IAlerter>(alerters);
            const double maxThreshold = 10.2;
            var _maximumThresholdAlerter = new MaximumThresholdAlerter( alertersList,maxThreshold);
            _maximumThresholdAlerter.CheckMaxAndAlert(new List<double> {  });

            Assert.True(!emailAlert.emailSent);
            Assert.True(!ledAlert.ledGlown);


        }
    }
}
