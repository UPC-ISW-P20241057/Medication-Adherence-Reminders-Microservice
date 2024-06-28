using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface IReminderService
{
    Task<IEnumerable<Reminder>> ListAsync();
    Task<IEnumerable<Reminder>> ListByUserId(long userId);
    Task<ReminderResponse> FindByIdAsync(long id);
    Task<ReminderResponse> SaveAsync(Reminder reminder);
    Task<ReminderResponse> UpdateAsync(long id, Reminder reminder);
    Task<ReminderResponse> DeleteAsync(long id);
}