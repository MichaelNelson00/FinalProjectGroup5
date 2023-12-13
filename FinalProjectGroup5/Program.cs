using System;

namespace FinalProjectGroup5;

public class Program
{
    //static variables used throughout the main method for various actions
    private static Customers customers;
    private static List<Reservation> reservations;
    private static List<CustomerReserved> customerReserved;
    private static Customer authenticatedCustomer;

    private static Customer customer;
    static void Main(string[] args)
    {
        Console.WriteLine("Initializing...");
        Initialize(); // Create and initialize all objects ...
        Menu(); //menu that allows for the user to interact with the program
    }

    static void Initialize()
    {
        //creates new Customer objects using the constructor
        var c1 = new Customer(001, "Albert Apple", "1111 Wells St, Milwaukee WI, 53233", 1234567891, "12/23/2002");
        var c2 = new Customer(002, "Billy Bob", "1510 W Wells St, Milwaukee WI, 53233", 1345678901, "10/11/1995");
        var c3 = new Customer(003, "Charles Coakley", "1210 Friday St, Brookfield WI, 53005", 1897520340, "06/15/1988");

        //sets the username and password for each user 
        c1.Username = "AlbertApple01";
        c1.Password = "1234";

        c2.Username = "BillyBob01";
        c2.Password = "abcd";

        c3.Username = "CharlesCoakley";
        c3.Password = "qwerty";

        //creates three new reservation objects using the constructor
        var r1 = new Reservation(237892469104819, new DateTime(2023,12,30,12,00,00), 2000);
        var r2 = new Reservation(423705720757890, new DateTime(2023,12,28,15,30,00), 2001);
        var r3 = new Reservation(237025347802544, new DateTime(2024,01,03,13,00,00), 2002);

        //creates two bike objects
        var b1 = new Bikes("B1", 100);
        var b2 = new Bikes("B2", 101);

        //creates two canoe objects
        var can1 = new Canoe("C1", 200);
        var can2 = new Canoe("C2", 201);

        //creates two kayak objects
        var k1 = new Kayak("K1", 300);
        var k2 = new Kayak("K2", 301);

        //creates two paddleboard objects
        var pb1 = new PaddleBoard("PB1", 400);
        var pb2 = new PaddleBoard("PB2", 401);

        //creates two tent objects
        var ten1 = new Tents("TEN1", 500);
        var ten2 = new Tents("TEN2", 501);

        //creates two tube objects
        var tub1 = new Tube("TUB1", 600);
        var tub2 = new Tube("TUB2", 601);

        //creates two objects of the customerreserved class
        var cr1 = new CustomerReserved(c1,b1,r1);
        var cr2 = new CustomerReserved(c2, k2, r2);
        var cr3 = new CustomerReserved(c3, tub1, r3);

        //list of all objects of the custoemr reserved class
        customerReserved = new List<CustomerReserved>();

        //sets the customers variable as new customers object
        //adds the customers created before into the list
        customers = new Customers();
        customers.customers.Add(c1);
        customers.customers.Add(c2);
        customers.customers.Add(c3);

       //adds the custoemr reservations to the custoemrreserved list
        customerReserved.Add(cr1);
        customerReserved.Add(cr3);
        customerReserved.Add(cr2);

        //adds the reservation objects to a new list of reservations
        reservations = new List<Reservation>();
        reservations.Add(r1);
        reservations.Add(r2);
        reservations.Add(r3);


    }

    //The menu method that allwos the user to interact with the program
    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Reservations: 4 --- Clear Screen: c --- Quit: q ---");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    LoginMenu();
                    break;
                case "2":
                    LogoutMenu();
                    break;
                case "3":
                    SignUpMenu();
                    break;
                case "4":
                    GetCurrentReservationsMenu();
                    break;
                case "c":
                    Console.Clear();
                    break;
                case "q":
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }

        }

    }

    //Loginmenu method that walks through the process of logging in, asking for the username and password and proceeeding appropriately
    static void LoginMenu()
    {
        if (authenticatedCustomer == null)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            authenticatedCustomer = customers.Authenticate(username, password);
            if (authenticatedCustomer != null)
            {
                Console.WriteLine($"Welcome {authenticatedCustomer.FullName}");
            }
            else
            {
                Console.WriteLine("invalid username or password");
            }
        }
        else
        {
            Console.WriteLine($"You are already logged in as {authenticatedCustomer.Username}");
        }
    }

    //method allowing the user to logout
    static void LogoutMenu()
    {
        authenticatedCustomer = null;
        Console.WriteLine("Logged out!");
    }

    //method that allows the user to create a new account, taking in their inputs
    static void SignUpMenu()
    {
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Write("Enter your address:");
        string address = Console.ReadLine() ;
        Console.Write("Enter your phone number with no dashes:");
        long phoneNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter your date of birth:");
        string dob = Console.ReadLine();

        var newCustomer = new Customer
        {
            FullName = fullName,
            Username = username,
            Password = password,
            Address = address,
            PhoneNumber = phoneNumber,
            DateofBirth = dob
            
        };

        customers.customers.Add(newCustomer);

        Console.WriteLine("Profile created!");

    }

    //method that allows the user to see their current reservations, prints out the details of the reservation
    static void GetCurrentReservationsMenu()
    {
        if (authenticatedCustomer == null)
        {
            Console.WriteLine("You are not logged in.");
            return;
        }

        var customerReservations = customerReserved
            .Where(cr => cr.Customer.Username == authenticatedCustomer.Username);

        if (customerReservations.Count() == 0)
        {
            Console.WriteLine("0 reservations found.");
        }
        else
        {
            Console.WriteLine("Current Reservations:");
            foreach (var customerReservation in customerReservations)
            {
                Console.WriteLine($"Reservation ID: {customerReservation.ReservationID}");
                Console.WriteLine($"Equipment: {customerReservation.Equipment.Name}");
                Console.WriteLine($"Start Date: {customerReservation.StartDate}");
                Console.WriteLine("---------------");
            }
        }
    }




}
