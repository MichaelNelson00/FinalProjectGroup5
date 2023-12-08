using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public abstract class Equipment
{
    // Data fields for the equipment class
    private string name;
    private bool fixStatus = false;
    public int serialNumber;
    private decimal flatCharge = 20;
    private decimal hourlyFine = 8;

    //property to get and set the serial number
    public int SerialNumber
    {
        get { return serialNumber; } 
        set { serialNumber = value; }
    }
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
    // Property to get the flat charge, no setter because the value will not be changed
    public decimal FlatCharge
    {
        get { return flatCharge; }
    }

    //Property to get hourlyFine, no setter as we want this value to be constant

    public decimal HourlyFine
    {
        get { return hourlyFine; }
    }
       
}
