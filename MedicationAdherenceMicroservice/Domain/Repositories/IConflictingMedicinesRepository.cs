using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IConflictingMedicinesRepository
{
    Task<ConflictingMedicines> FindByMedicineNames(string name1, string name2);
    Task AddAsync(ConflictingMedicines conflictingMedicines);
}