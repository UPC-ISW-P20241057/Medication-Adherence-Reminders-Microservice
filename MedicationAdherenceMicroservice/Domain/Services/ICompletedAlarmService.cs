using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface ICompletedAlarmService
{
    Task<IEnumerable<CompletedAlarm>> ListByUserId(long userId);
    Task<CompletedAlarmResponse> SaveAsync(CompletedAlarm completedAlarm);
}