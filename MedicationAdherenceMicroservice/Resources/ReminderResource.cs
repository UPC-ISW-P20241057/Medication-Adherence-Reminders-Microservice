namespace MedicationAdherenceMicroservice.Resources;

public class ReminderResource
{
    public long Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public short? Pills { get; set; }
    public DateTime? EndDate { get; set; }
    public long UserId { get; set; }
    public MedicineResource Medicine { get; set; }
    public FrequencyResource? Frequency { get; set; }
    public IntervalResource? Interval { get; set; }
    public bool? ConsumeFood { get; set; }
}