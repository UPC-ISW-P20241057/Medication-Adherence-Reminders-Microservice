using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface IMissedAlarmService
{
    Task<IEnumerable<MissedAlarm>> ListByUserId(long userId);
    Task<MissedAlarmResponse> SaveAsync(MissedAlarm missedAlarm);
}