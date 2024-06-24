using System.ComponentModel.DataAnnotations;

namespace MedicationAdherenceMicroservice.Resources;

public class SaveConflictingMedicinesResource
{
    [Required]
    public long Medicine1Id { get; set; }
    [Required]
    public long Medicine2Id { get; set; }
}