using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Resources;

public class SaveReminderResource
{
    [Required]
    public DateTime CreatedDate { get; set; }
    public short? Pills { get; set; }
    public DateTime? EndDate { get; set; }
    [Required]
    public long UserId { get; set; }
    [Required]
    public long MedicineId { get; set; }
    public bool? ConsumeFood { get; set; }
}