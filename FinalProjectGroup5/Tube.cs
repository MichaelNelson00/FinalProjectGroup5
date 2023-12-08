using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public class Tube : Water
{
    //data fields for the tube class, both rates are set as they are constant
    private decimal hourlyRate = 6;
    private decimal dailyRate = 30;

    //Properties to get the two data fields, no setters as these values are constant

    public decimal HourlyRate
    {
        get { return hourlyRate; }
    }

    public decimal DailyRate
    {
        get { return dailyRate; }
    }
}
