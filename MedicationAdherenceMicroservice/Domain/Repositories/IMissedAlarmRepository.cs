using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IMissedAlarmRepository
{
    Task<IEnumerable<MissedAlarm>> ListByUserId(long userId);
    Task AddAsync(MissedAlarm missedAlarm);
}