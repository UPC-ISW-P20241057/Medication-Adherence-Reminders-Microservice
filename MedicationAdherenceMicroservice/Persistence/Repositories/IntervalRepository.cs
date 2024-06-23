using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class IntervalRepository(AppDbContext context) : BaseRepository(context), IIntervalRepository
{
    public async Task AddAsync(Interval interval)
    {
        await _context.Intervals.AddAsync(interval);
    }

    public void Update(Interval interval)
    {
        _context.Intervals.Update(interval);
    }
}