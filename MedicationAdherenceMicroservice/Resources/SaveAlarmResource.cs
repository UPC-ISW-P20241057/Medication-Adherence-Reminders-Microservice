using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Resources;

public class SaveAlarmResource
{
    [Required]
    public string MedicineName { get; set; }
    [Required]
    public string ActivateDateString { get; set; }
    [Required]
    public int ActivateHour { get; set; }
    [Required]
    public int ActivateMinute { get; set; }
    public bool? ConsumeFood { get; set; }
    [Required]
    public long UserId { get; set; }
}