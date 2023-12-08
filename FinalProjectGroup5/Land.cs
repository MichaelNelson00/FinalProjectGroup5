using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public abstract class Land : Equipment
{
    //data fields for all children of the land class, maximum reservation is 7 days
    private int maxDaysReserved = 7;

    //property to get the max days reserved, no setter as this variable is constant

    public int MaxDaysReserved
    {
        get { return maxDaysReserved; }

    }
}
   
