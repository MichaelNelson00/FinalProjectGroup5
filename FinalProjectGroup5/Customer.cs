using System;
namespace FinalProjectGroup5;

public class Customer
{
	public int customerID;
	public string fullName;
	public string address;
	public int phoneNumber;
	public string dateofBirth;

	public Customer(int customerid, string fullname, string Address, int phonenumber, string dateofbirth)
	{
		customerID = customerid;
		fullName = fullname;
		address = Address;
		phoneNumber = phonenumber;
		dateofBirth = dateofbirth;
	}
}

