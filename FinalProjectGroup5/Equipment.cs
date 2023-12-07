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

    // Property to get or set the value of the Name field
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Abstract method (you can add more abstract methods as needed)
    public abstract void DisplayInfo();
}
