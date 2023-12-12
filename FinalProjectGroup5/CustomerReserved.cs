using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public class CustomerReserved
{
        // Data fields
        private Customer customer;
        private Equipment equipment;
        private int  reservationID;
        private DateTime startdate;

    // Properties to access the data fields
    public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Equipment Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }

        public int ReservationID
        {
        get { return reservationID; }
        }
         public DateTime StartDate
    {
        get { return startdate; }
    }

    // Constructor to initialize the data fields
    public CustomerReserved(Customer customer, Equipment equipment, Reservation reservation)
        {
            this.customer = customer;
            this.equipment = equipment;
            this.reservationID = reservation.ReservationId;
            this.startdate = reservation.StartDate;
        }

}
