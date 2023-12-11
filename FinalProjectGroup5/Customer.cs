using System;
namespace FinalProjectGroup5;

public class Customer
{
    //datafields for the customer class
    private int customerID;
    private string fullName;
    private string address;
    private int phoneNumber;
    private string dateofBirth;
    private List<int> reservedItems = new List<int>();

    //constructor for the customer class
    public Customer(int customerid, string fullname, string Address, int phonenumber, string dateofbirth)
    {
        this.customerID = customerid;
        this.fullName = fullname;
        this.address = Address;
        this.phoneNumber = phonenumber;
        this.dateofBirth = dateofbirth;
    }
    
    public List<int> ReservedItems(int customerID)
    {
        return reservedItems;
    }

    public decimal OverdueFines(Customer customerID)
    {
        return Reservation.OverdueFines;
    }

    public void Reserve(int serialNumber, DateTime startDate, int durationHours)
    {
        reservedItems.Add(serialNumber);
    }

    public void Request(serialNumber item)
    {

    }

    public DateTime WhenDue(serialNumber item)
    {

    }

    public decimal DamageFees(serialNumber item)
    {

    }

}

