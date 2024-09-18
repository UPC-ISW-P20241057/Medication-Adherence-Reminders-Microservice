using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class CompletedAlarmRepository(AppDbContext context): BaseRepository(context), ICompletedAlarmRepository
{
    public async Task<IEnumerable<CompletedAlarm>> ListByUserId(long userId)
    {
        return await _context.CompletedAlarms.Where(p => p.UserId == userId).ToListAsync();
    }

    public async Task AddAsync(CompletedAlarm completedAlarm)
    {
        await _context.CompletedAlarms.AddAsync(completedAlarm);
    }
}