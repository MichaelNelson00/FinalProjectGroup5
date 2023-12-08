using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public abstract class Water : Equipment
{
    //data field for all members of the water class, maximum reservation is 2 days
    private int maxDaysReserved = 2;

    //property to get the maximum reservation length of water items

    public int MaxDaysReserved
    {
        get { return maxDaysReserved; }
    }

}
