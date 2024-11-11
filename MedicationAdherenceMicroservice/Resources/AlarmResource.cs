﻿namespace MedicationAdherenceMicroservice.Resources;

public class AlarmResource
{
    public long Id { get; set; }
    public string MedicineName { get; set; }
    public string ActivateDateString { get; set; }
    public int ActivateHour { get; set; }
    public int ActivateMinute { get; set; }
    public bool? ConsumeFood { get; set; }
}