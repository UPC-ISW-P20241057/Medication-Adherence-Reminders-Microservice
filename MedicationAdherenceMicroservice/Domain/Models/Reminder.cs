namespace MedicationAdherenceMicroservice.Domain.Models;

public class Reminder
{
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public short? Pills { get; set; }
    public DateTime? EndDate { get; set; }
    
    public long MedicineId { get; set; }
    public long UserId { get; set; }
    public Medicine Medicine { get; set; }
    
    public Frequency? Frequency { get; set; }
    public Interval? Interval { get; set; }
    
    public bool? ConsumeFood { get; set; }
}