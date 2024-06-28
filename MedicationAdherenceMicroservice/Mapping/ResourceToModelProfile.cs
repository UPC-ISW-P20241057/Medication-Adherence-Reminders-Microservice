using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Resources;

namespace MedicationAdherenceMicroservice.Mapping;

public class ResourceToModelProfile: Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveMedicineResource, Medicine>();
        CreateMap<SaveReminderResource, Reminder>();
        CreateMap<SaveIntervalResource, Interval>();
        CreateMap<SaveFrequencyResource, Frequency>();
        CreateMap<SaveConflictingMedicinesResource, ConflictingMedicines>();
    }
}