using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class FrequencyRepository(AppDbContext context) : BaseRepository(context), IFrequencyRepository
{
    public async Task AddAsync(Frequency frequency)
    {
        await _context.Frequencies.AddAsync(frequency);
    }

    public void Update(Frequency frequency)
    {
        _context.Frequencies.Update(frequency);
    }
}