using System;
namespace FinalProjectGroup5;

public class Customer
{
    private int customerID;
    private string fullName;
    private string address;
    private int phoneNumber;
    private string dateofBirth;
    private List<serialNumber> ReservedItems = new List<serialNumber>;

    public Customer(int customerid, string fullname, string Address, int phonenumber, string dateofbirth)
    {
        this.customerID = customerid;
        this.fullName = fullname;
        this.address = Address;
        this.phoneNumber = phonenumber;
        this.dateofBirth = dateofbirth;
    }

    public List<serialNumber> ItemsReserved()
    {
        return ReservedItems;
    }

    public decimal OverdueFines()
    {

    }

    public void Reserve(serialNumber item, DateTime startDate, int durationHours)
    {

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

