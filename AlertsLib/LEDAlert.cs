using System;

namespace AlertsLib
{
    public class LEDAlert: IAlerter
    { 
        public bool ledGlown=false;
    public void Alert(double maxThreshold, double _maximum)
    {
        if(maxThreshold<_maximum)
        {
            this.ledGlown=true;
        }

    }
    
    
     }
}
