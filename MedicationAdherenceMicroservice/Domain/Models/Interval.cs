namespace MedicationAdherenceMicroservice.Domain.Models;

public class Interval
{
    public long Id { get; set; }
    public string IntervalType { get; set; }
    public int Value { get; set; }
    
    public Reminder Reminder { get; set; }
    public long ReminderId { get; set; }
}