﻿namespace MedicationAdherenceMicroservice.Domain.Models;

public class ConflictingMedicines
{
    public long Id { get; set; }
    public long Medicine1Id { get; set; }
    public string Medicine1Name { get; set; }
    public long Medicine2Id { get; set; }
    public string Medicine2Name { get; set; }
}