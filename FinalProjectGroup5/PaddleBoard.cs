using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public class PaddleBoard : Water
{
    //datafields for the paddleboard class, hourly rate is 10 and daily rate is 35
    private decimal hourlyRate = 10;
    private decimal dailyRate = 35;

    //Properties to get the datafield values, no setters as we want these constant
    public decimal HourlyRate
    {
        get { return hourlyRate; }
    }

    public decimal DailyRate
    {
        get { return dailyRate; }
    }
    // constructor for paddleboard class, takes a string variable and an integer as parameters
    public PaddleBoard(string name, int serialnumber)
    {
        Name = name;
        SerialNumber = serialnumber;
    }
}
