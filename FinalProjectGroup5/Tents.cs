using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5
{
    public class Tents : Land
        
    {
        // the data fields for the tents class, only a dailyrate as hourly doesn't make sense

        private decimal dailyRate = 20;

        //property to get the dailyrate for tents, no setter as we want the value to be constant
        public decimal DailyRate
        {
            get { return dailyRate; }
        }
    }

   


}
