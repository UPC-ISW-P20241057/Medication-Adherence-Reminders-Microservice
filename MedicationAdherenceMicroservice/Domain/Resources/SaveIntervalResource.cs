using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Domain.Resources;

public class SaveIntervalResource
{
    [Required]
    public string IntervalType { get; set; }
    [Required]
    public int Value { get; set; }
}