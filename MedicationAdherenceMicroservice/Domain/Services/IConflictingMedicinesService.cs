using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface IConflictingMedicinesService
{
    Task<ConflictingMedicinesResponse> FindByMedicineNamesAsync(string name1, string name2);
    Task<ConflictingMedicinesResponse> SaveAsync(ConflictingMedicines conflictingMedicines);
}