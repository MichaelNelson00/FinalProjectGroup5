using System;
using System.Runtime.InteropServices;

namespace FinalProjectGroup5;

public class Customer
{
    //datafields for the customer class
    private int customerID;
    private string fullName;
    private string address;
    private long phoneNumber;
    private string dateofBirth;
    private List<int> reservedItems = new List<int>();

    //two more datafields with getters and setters right away
    public string Username { get; set; }
    public string Password { get; set; }

    //properties for the datafields
    public string DateofBirth
    {
        get { return dateofBirth; }
        set { dateofBirth = value; }
    }
    public long PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }
   

    //constructor for the customer class
    public Customer(int customerid, string fullname, string Address, long phonenumber, string dateofbirth)
    {
        this.customerID = customerid;
        this.fullName = fullname;
        this.address = Address;
        this.phoneNumber = phonenumber;
        this.dateofBirth = dateofbirth;
    }
    
    //method that allows to see what specific objects a customer has reserved
    public List<int> ReservedItems(int customerID)
    {
        return reservedItems;
    }

    //method that allows for a reservation to be made, adds the item to the list consisting of the items the customer has reserved
    public void Reserve(int serialNumber, DateTime startDate, int durationHours)
    {
        reservedItems.Add(serialNumber);
    }

    //no arg constructor for the Customer class
    public Customer()
    {

    }

}

