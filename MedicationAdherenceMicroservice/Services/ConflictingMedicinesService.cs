using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Services;

public class ConflictingMedicinesService(
    IConflictingMedicinesRepository conflictingMedicinesRepository,
    IMedicineRepository medicineRepository,
    IUnitOfWork unitOfWork
    ): IConflictingMedicinesService
{
    public async Task<ConflictingMedicinesResponse> FindByMedicineNamesAsync(string name1, string name2)
    {
        var existingRegister = await conflictingMedicinesRepository.FindByMedicineNames(name1, name2);

        return existingRegister == null
            ? new ConflictingMedicinesResponse("Medicines aren´t conflict.")
            : new ConflictingMedicinesResponse(existingRegister);
    }

    public async Task<ConflictingMedicinesResponse> SaveAsync(ConflictingMedicines conflictingMedicines)
    {
        var medicine1 = await medicineRepository.FindByIdAsync(conflictingMedicines.Medicine1Id);
        var medicine2 = await medicineRepository.FindByIdAsync(conflictingMedicines.Medicine2Id);

        if (!(medicine1 != null && medicine2 != null))
            return new ConflictingMedicinesResponse("One or both medicines doesn't exist.");

        conflictingMedicines.Medicine1Name = medicine1.Name;
        conflictingMedicines.Medicine2Name = medicine2.Name;
        
        try
        {
            await conflictingMedicinesRepository.AddAsync(conflictingMedicines);
            await unitOfWork.CompleteAsync();
            return new ConflictingMedicinesResponse(conflictingMedicines);
        }
        catch (Exception e)
        {
            return new ConflictingMedicinesResponse($"An error occurred while saving the register: {e.Message}");
        }
    }
}