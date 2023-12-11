namespace FinalProjectGroup5;

public class Program
{
    private static Customer customers;
    private static List<Reservation> reserved;
    private static List<CustomerReserved> customerReserved;
    private static Customer authenticatedCustomer;

    private static Customer customer;
    static void Main(string[] args)
    {
        Console.WriteLine("Initializing...");
        Initialize(); // Create and initialize all objects ...
        Menu();
    }

    static void Initialize()
    {
        var c1 = new Customer(001, "Albert Apple", "1111 Wells St, Milwaukee WI, 53233", 1234567891, "12/23/2002");
        var c2 = new Customer(002, "Billy Bob", "1510 W Wells St, Milwaukee WI, 53233", 1345678901, "10/11/1995");
        var c3 = new Customer(003, "Charles Coakley", "1210 Friday St, Brookfield WI, 53005", 1897520340, "06/15/1988");

        var r1 = new Reservation(237892469104819, new DateTime(12,30,2023,12,00,00), 2000);
        var r2 = new Reservation(423705720757890, new DateTime(12,28,2023,3,30,00), 2001);
        var r3 = new Reservation(237025347802544, new DateTime(01,03,2024,1,00,00), 2002);

        var b1 = new Bikes("B1", 100);
        var b2 = new Bikes("B2", 101);

        var can1 = new Canoe("C1", 200);
        var can2 = new Canoe("C2", 201);

        var k1 = new Kayak("K1", 300);
        var k2 = new Kayak("K2", 301);

        var pb1 = new PaddleBoard("PB1", 400);
        var pb2 = new PaddleBoard("PB2", 401);

        var ten1 = new Tents("TEN1", 500);
        var ten2 = new Tents("TEN2", 501);

        var tub1 = new Tube("TUB1", 600);
        var tub2 = new Tube("TUB2", 601);

        var cr1 = new CustomerReserved(c1,b1,r1);
        var cr2 = new CustomerReserved(c2, k2, r2);
        var cr3 = new CustomerReserved(c3, tub1, r3);

        customers = new Customer();
        customers.customer.Add(c1);
        customers.customers.Add(c2);

        
        appointments.Add(a1);
        appointments.Add(a2);
        appointments.Add(a3);

        customerAppointments.Add(ca1);
        customerAppointments.Add(ca2);
        customerAppointments.Add(ca3);


    }

    static void Menu()
    {
        bool done = false;

        while (!done)
        {
            Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Appointments: 4 --- Clear Screen: c --- Quit: q ---");
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
                    GetCurrentAppointmentsMenu();
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
                Console.WriteLine($"Welcome {authenticatedCustomer.FirstName}");
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

    static void LogoutMenu()
    {
        authenticatedCustomer = null;
        Console.WriteLine("Logged out!");
    }

    static void SignUpMenu()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string LastName = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var newCustomer = new Customer
        {
            FirstName = firstName,
            LastName = LastName,
            Username = username,
            Password = password
        };

        customers.customers.Add(newCustomer);

        Console.WriteLine("Profile created!");

    }


    static void GetCurrentAppointmentsMenu()
    {
        if (authenticatedCustomer == null)
        {
            Console.WriteLine("You are not logged in.");
            return;
        }


        var appointmentList = customerAppointments.Where(o => o.customer.Username == authenticatedCustomer.Username);

        if (appointmentList.Count() == 0)
        {
            Console.WriteLine("0 appointment found.");
        }
        else
        {
            foreach (var appointmnet in appointmentList)
            {
                Console.WriteLine(appointmnet.appointment.date);
            }
        }
    }




}
