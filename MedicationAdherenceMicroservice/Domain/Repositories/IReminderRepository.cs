using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IReminderRepository
{
    Task<IEnumerable<Reminder>> ListAsync();
    Task<IEnumerable<Reminder>> ListByUserId(long userId);
    Task AddAsync(Reminder reminder);
    Task<Reminder> FindByIdAsync(long id);
    void Update(Reminder reminder);
    void Remove(Reminder reminder);
}