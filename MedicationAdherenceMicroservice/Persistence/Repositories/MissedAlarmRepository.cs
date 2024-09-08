using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class MissedAlarmRepository(AppDbContext context): BaseRepository(context), IMissedAlarmRepository
{
    public async Task<IEnumerable<MissedAlarm>> ListByUserId(long userId)
    {
        return await _context.MissedAlarms.Where(p => p.UserId == userId).ToListAsync();
    }

    public async Task AddAsync(MissedAlarm missedAlarm)
    {
        await _context.MissedAlarms.AddAsync(missedAlarm);
    }
}