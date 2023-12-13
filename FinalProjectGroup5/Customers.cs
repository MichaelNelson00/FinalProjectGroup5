using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup5;

public class Customers
{
    //Customers class allows for the main method and customer authentication to function
    //List consisting of members of the Customer class
    public List<Customer> customers { get; set; }

    //Constructor for the class
    public Customers()
    {
        customers = new List<Customer>();
    }
    //method used in customer authentication in the main method
    public Customer Authenticate(string username, string password)
    {
        var c = customers.Where(o => (o.Username == username) && (o.Password == password));

        if(c.Count() > 0)
        {
            return c.First();
        }
        else
        {
            return null;
        }
    }
}
