using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Resources;

public class SaveFrequencyResource
{
    [Required]
    public string FrequencyType { get; set; }
    [Required]
    public int Times { get; set; }
    [Required]
    public long ReminderId { get; set; }
}