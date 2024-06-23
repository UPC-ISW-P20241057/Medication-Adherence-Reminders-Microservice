using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Services;

public class MedicineService(IMedicineRepository medicineRepository, IUnitOfWork unitOfWork)
    : IMedicineService
{
    public async Task<IEnumerable<Medicine>> ListAsync()
    {
        return await medicineRepository.ListAsync();
    }

    public async Task<MedicineResponse> SaveAsync(Medicine medicine)
    {
        var existingMedicineWithName = await medicineRepository.FindByNameAsync(medicine.Name);
        if (existingMedicineWithName != null)
            return new MedicineResponse("Medicine with name already exists.");

        try
        {
            await medicineRepository.AddAsync(medicine);
            await unitOfWork.CompleteAsync();
            return new MedicineResponse(medicine);
        }
        catch (Exception e)
        {
            return new MedicineResponse($"An error occurred while saving the new medicine: {e.Message}");
        }
    }

    public async Task<MedicineResponse> FindByIdAsync(long id)
    {
        var existingMedicine = await medicineRepository.FindByIdAsync(id);
        if (existingMedicine == null) return new MedicineResponse($"Invalid medicine with id {id}.");
        return new MedicineResponse(existingMedicine);
    }

    public async Task<MedicineResponse> UpdateAsync(long id, Medicine medicine)
    {
        var existingMedicine = await medicineRepository.FindByIdAsync(id);
        if (existingMedicine == null) return new MedicineResponse($"Invalid medicine with id {id}.");
        
        existingMedicine.Name = medicine.Name;
        existingMedicine.Type = medicine.Type;
        
        try
        {
            medicineRepository.Update(existingMedicine);
            await unitOfWork.CompleteAsync();
            return new MedicineResponse(existingMedicine);
        }
        catch (Exception e)
        {
            return new MedicineResponse($"An error occurred while updating the medicine: {e.Message}");
        }
    }

    public async Task<MedicineResponse> DeleteAsync(long id)
    {
        var existingMedicine = await medicineRepository.FindByIdAsync(id);
        if (existingMedicine == null) return new MedicineResponse($"Invalid medicine with id {id}.");
        
        try
        {
            medicineRepository.Remove(existingMedicine);
            await unitOfWork.CompleteAsync();
            return new MedicineResponse(existingMedicine);
        }
        catch (Exception e)
        {
            return new MedicineResponse($"An error occurred while removing the medicine: {e.Message}");
        }
    }
}