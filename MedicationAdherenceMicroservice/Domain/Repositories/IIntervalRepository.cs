using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IIntervalRepository
{
    Task<Interval> FindByIdAsync(long id);
    Task<Interval> FindByReminderIdAsync(long reminderId);
    Task AddAsync(Interval interval);
    void Update(Interval interval);
}