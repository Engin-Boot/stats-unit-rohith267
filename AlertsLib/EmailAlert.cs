using System;

namespace AlertsLib
{
    public class EmailAlert: IAlerter
    { 
       public bool emailSent=false;
    public void Alert(double maxThreshold, double _maximum)
    {
        if(maxThreshold<_maximum)
        {
            this.emailSent=true;
        }

    }
    
    
     }
}
