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
    private int serialNumber;

    //property to set the serial number
    public int SerialNumber
    {
        get { return serialNumber; } set { serialNumber = value; }
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
   
        // Properties to get or set the values of the various data fields
       
}
