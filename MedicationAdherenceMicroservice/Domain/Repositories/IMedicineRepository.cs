using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IMedicineRepository
{
    Task<IEnumerable<Medicine>> ListAsync();
    Task AddAsync(Medicine medicine);
    Task<Medicine> FindByIdAsync(long id);
    Task<Medicine> FindByNameAsync(string name);
    void Update(Medicine medicine);
    void Remove(Medicine medicine);
}