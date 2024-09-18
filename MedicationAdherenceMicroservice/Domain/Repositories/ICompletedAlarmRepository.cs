using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface ICompletedAlarmRepository
{
    Task<IEnumerable<CompletedAlarm>> ListByUserId(long userId);
    Task AddAsync(CompletedAlarm completedAlarm);
}