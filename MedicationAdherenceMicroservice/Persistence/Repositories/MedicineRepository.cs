using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class MedicineRepository(AppDbContext context) : BaseRepository(context), IMedicineRepository
{
    public async Task<IEnumerable<Medicine>> ListAsync()
    {
        return await _context.Medicines.ToListAsync();
    }

    public async Task AddAsync(Medicine medicine)
    {
        await _context.Medicines.AddAsync(medicine);
    }

    public async Task<Medicine> FindByIdAsync(long id)
    {
        return await _context.Medicines
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Medicine> FindByNameAsync(string name)
    {
        return await _context.Medicines
            .FirstOrDefaultAsync(p => p.Name == name);
    }

    public void Update(Medicine medicine)
    {
        _context.Medicines.Update(medicine);
    }

    public void Remove(Medicine medicine)
    {
        _context.Medicines.Remove(medicine);
    }
}