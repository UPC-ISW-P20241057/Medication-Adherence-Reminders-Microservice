namespace MedicationAdherenceMicroservice.Domain.Models;

public class Frequency
{
    public long Id { get; set; }
    public string FrequencyType { get; set; }
    public int Times { get; set; }
    
    public Reminder Reminder { get; set; }
    public long ReminderId { get; set; }
}