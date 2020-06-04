using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITravelStrategyDemo
{
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;
        // The Client will set what TravelStrategy to use by 
        // calling this method at runtime
        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            this.travelStrategy = strategy;
        }
        public void gotoAirport()
        {
            travelStrategy.GotoAirport();
        }
    }
}
