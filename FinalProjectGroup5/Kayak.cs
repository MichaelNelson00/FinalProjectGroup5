using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public class Kayak : Water
{
    //datafields for the kayak class
    private decimal hourlyRate = 20;
    private decimal dailyRate = 50;

    //Properties to get the datafield values, no setters as we want these constant
    public decimal HourlyRate
    {
        get { return hourlyRate; }
    }

    public decimal DailyRate
    {
        get { return dailyRate; }
    }
}
