using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Resources;

public class SaveIntervalResource
{
    [Required]
    public string IntervalType { get; set; }
    [Required]
    public int Value { get; set; }
    [Required]
    public long ReminderId { get; set; }
}