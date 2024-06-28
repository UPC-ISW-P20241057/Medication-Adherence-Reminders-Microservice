namespace MedicationAdherenceMicroservice.Domain.Models;

public class Medicine
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public IList<Reminder> Reminders { get; set; } = new List<Reminder>();
}