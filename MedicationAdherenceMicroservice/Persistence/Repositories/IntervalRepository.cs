using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class IntervalRepository(AppDbContext context) : BaseRepository(context), IIntervalRepository
{
    public async Task<Interval> FindByIdAsync(long id)
    {
        return await _context.Intervals
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Interval> FindByReminderIdAsync(long reminderId)
    {
        return await _context.Intervals
            .FirstOrDefaultAsync(p => p.ReminderId == reminderId);
    }

    public async Task AddAsync(Interval interval)
    {
        await _context.Intervals.AddAsync(interval);
    }

    public void Update(Interval interval)
    {
        _context.Intervals.Update(interval);
    }
}