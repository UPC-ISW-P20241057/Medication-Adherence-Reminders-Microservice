using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface IMedicineService
{
    Task<IEnumerable<Medicine>> ListAsync();
    Task<MedicineResponse> SaveAsync(Medicine medicine);
    Task<MedicineResponse> FindByIdAsync(long id);
    Task<MedicineResponse> UpdateAsync(long id, Medicine medicine);
    Task<MedicineResponse> DeleteAsync(long id);
}