namespace MedicationAdherenceMicroservice.Resources;

public class FrequencyResource
{
    public long Id { get; set; }
    public string FrequencyType { get; set; }
    public int Times { get; set; }
}