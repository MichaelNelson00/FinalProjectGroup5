using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public abstract class Equipment
{
    // Data field
    private string name;
    private bool fixStatus = false;
    private decimal hourlyRate;
    private decimal dailyRate;
    private int reservationPeriod;
    private decimal hourlyFine;

    // Property to get or set the value of the Name field
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    // Property to get or set the fix status, false means item is fixed, true means it is damaged
        public bool FixStatus
        {
        get { return fixStatus; }
        set { fixStatus = value; }
        }
   
        // Properties to get or set the values of the various data fields
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public decimal DailyRate
        {
            get { return dailyRate; }
            set { dailyRate = value; }
        }

        public int ReservationPeriod
        {
            get { return reservationPeriod; }
            set { reservationPeriod = value; }
        }

        public decimal HourlyFine
        {
            get { return hourlyFine; }
            set { hourlyFine = value; }
        }
}
