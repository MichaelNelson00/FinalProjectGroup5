using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public class CustomerReserved
{
        // Data fields
        private Customer customer;
        private Equipment equipment;
        private Reservation reservationID;

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

        // Constructor to initialize the data fields
        public CustomerReserved(Customer customer, Equipment equipment, Reservation reservationID)
        {
            this.customer = customer;
            this.equipment = equipment;
            this.reservationID = reservationID;
        }

}
