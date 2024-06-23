namespace MedicationAdherenceMicroservice.Domain.Resources;

public class IntervalResource
{
    public long Id { get; set; }
    public string IntervalType { get; set; }
    public int Value { get; set; }
}