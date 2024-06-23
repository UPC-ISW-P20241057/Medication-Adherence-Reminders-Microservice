using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Domain.Resources;

public class SaveFrequencyResource
{
    [Required]
    public string FrequencyType { get; set; }
    [Required]
    public int Times { get; set; }
}