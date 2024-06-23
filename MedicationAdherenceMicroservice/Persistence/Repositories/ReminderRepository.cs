using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class ReminderRepository(AppDbContext context) : BaseRepository(context), IReminderRepository
{
    public async Task<IEnumerable<Reminder>> ListAsync()
    {
        return await _context.Reminders
            .Include(p => p.Medicine)
            .Include(p => p.Interval)
            .Include(p => p.Frequency)
            .ToListAsync();
    }

    public async Task<IEnumerable<Reminder>> ListByUserId(long userId)
    {
        return await _context.Reminders.Where(p => p.UserId == userId).Include(p => p.Medicine).Include(p => p.Interval)
            .Include(p => p.Frequency).ToListAsync();
    }

    public async Task AddAsync(Reminder reminder)
    {
        await _context.Reminders.AddAsync(reminder);
    }

    public async Task<Reminder> FindByIdAsync(long id)
    {
        return await _context.Reminders
            .Include(p => p.Medicine)
            .Include(p => p.Interval)
            .Include(p => p.Frequency)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public void Update(Reminder reminder)
    {
        _context.Reminders.Update(reminder);
    }

    public void Remove(Reminder reminder)
    {
        _context.Reminders.Remove(reminder);
    }
}