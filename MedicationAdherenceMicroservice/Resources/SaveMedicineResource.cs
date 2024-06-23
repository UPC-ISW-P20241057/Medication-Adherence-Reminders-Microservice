using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Resources;

public class SaveMedicineResource
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }
}