using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Resources;

namespace MedicationAdherenceMicroservice.Mapping;

public class ModelToResourceProfile: Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Medicine, MedicineResource>();
        CreateMap<Reminder, ReminderResource>();
        CreateMap<Interval, IntervalResource>();
        CreateMap<Frequency, FrequencyResource>();
        CreateMap<ConflictingMedicines, ConflictingMedicinesResource>();
    }
}