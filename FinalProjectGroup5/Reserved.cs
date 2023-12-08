using System; 
  
public class Reservation 
{ 
    // Data points 
    public string CreditCardInfo { get; set; } 
    public DateTime DueDate { get; set; } 
    public decimal OverdueFines { get; set; } 
    public decimal DamageFees { get; set; } 
    public int TimesRenewed { get; set; } 
    public DateTime? DateReturned { get; set; } 
  
    // Constructor 
    public Reservation(string creditCardInfo, DateTime dueDate) 
    { 
        CreditCardInfo = creditCardInfo; 
        DueDate = dueDate; 
        OverdueFines = 0.0m; 
        DamageFees = 0.0m; 
        TimesRenewed = 0; 
        DateReturned = null; 
    } 
  
    // Methods for reservation actions 
    public void Renew() 
    { 
        // Example: Increment the number of times renewed 
        TimesRenewed++; 
    } 
  
    public void Return(DateTime returnDate) 
    { 
        // Example: Set the return date 
        DateReturned = returnDate; 
  
        // Example: Calculate overdue fines (if any) 
        if (returnDate > DueDate) 
        { 
            TimeSpan overdueDuration = returnDate - DueDate; 
            OverdueFines = CalculateOverdueFines(overdueDuration); 
        } 
    } 
  
    public void ReportDamage(decimal damageAmount) 
    { 
        // Example: Add damage fees 
        DamageFees += damageAmount; 
    } 
  
    private decimal CalculateOverdueFines(TimeSpan overdueDuration) 
    { 
        // Example: Calculate overdue fines based on a certain rate per day 
        decimal overdueRatePerDay = 5.0m; // Example rate per day 
        return (decimal)overdueDuration.TotalDays * overdueRatePerDay; 
    } 
} 
  
class Program 
{ 
    static void Main() 
    { 
        // Example usage 
        Reservation reservation = new Reservation("1234-5678-9012-3456", DateTime.Now.AddDays(7)); 
  
        reservation.Renew(); 
  
        DateTime returnDate = DateTime.Now.AddDays(10); 
        reservation.Return(returnDate); 
  
        reservation.ReportDamage(20.0m); 
  
        Console.WriteLine($"Credit Card Info: {reservation.CreditCardInfo}"); 
        Console.WriteLine($"Due Date: {reservation.DueDate}"); 
        Console.WriteLine($"Overdue Fines: {reservation.OverdueFines:C}"); 
        Console.WriteLine($"Damage Fees: {reservation.DamageFees:C}"); 
        Console.WriteLine($"Times Renewed: {reservation.TimesRenewed}"); 
        Console.WriteLine($"Date Returned: {reservation.DateReturned}"); 
    } 
} 

