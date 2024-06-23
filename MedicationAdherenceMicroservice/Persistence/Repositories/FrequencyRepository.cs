using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class FrequencyRepository(AppDbContext context) : BaseRepository(context), IFrequencyRepository
{
    public async Task<Frequency> FindByIdAsync(long id)
    {
        return await _context.Frequencies
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Frequency> FindByReminderId(long reminderId)
    {
        return await _context.Frequencies
            .FirstOrDefaultAsync(p => p.ReminderId == reminderId);
    }

    public async Task AddAsync(Frequency frequency)
    {
        await _context.Frequencies.AddAsync(frequency);
    }

    public void Update(Frequency frequency)
    {
        _context.Frequencies.Update(frequency);
    }
}