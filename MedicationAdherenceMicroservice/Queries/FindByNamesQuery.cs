using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Queries;

public class FindByNamesQuery
{
    [Required]
    public string Name1 { get; set; }
    [Required]
    public string Name2 { get; set; }
}