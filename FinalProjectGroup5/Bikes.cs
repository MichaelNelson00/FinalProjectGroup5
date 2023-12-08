using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5
{
    public class Bikes : Land
    {
        // These are the data fields unique to the bike class.
        private decimal hourlyRate = 8;
        private decimal dailyRate = 50;

        /*properties to access the hourlyRate and dailyRate datafields.
          No setters as we do not want these to change*/
        public decimal HourlyRate
        {
            get { return hourlyRate;}
        }

        public decimal DailyRate
        {
            get { return dailyRate; }
        }
}
