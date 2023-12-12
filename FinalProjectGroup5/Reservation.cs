using System; 
  
public class Reservation 
{ 
    // Data points for the reservation class
    public int ReservationId { get; set; }
    public long CreditCardNum { get; set; } 
    public DateTime DueDate { get; set; } 
    public decimal OverdueFines { get; set; } 
    public decimal DamageFees { get; set; } 
    public int TimesRenewed { get; set; } 
    public DateTime? DateReturned { get; set; } 
    public DateTime StartDate {  get; set; }   
  
    // Constructor 
    public Reservation(long creditCardNum, DateTime dueDate,int reservationId) 
    { 
        CreditCardNum = creditCardNum; 
        DueDate = dueDate; 
        ReservationId = reservationId;
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
 

