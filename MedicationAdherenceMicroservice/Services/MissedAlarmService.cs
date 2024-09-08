using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Services;

public class MissedAlarmService(IMissedAlarmRepository repository, IUnitOfWork unitOfWork): IMissedAlarmService
{
    public async Task<IEnumerable<MissedAlarm>> ListByUserId(long userId)
    {
        return await repository.ListByUserId(userId);
    }

    public async Task<MissedAlarmResponse> SaveAsync(MissedAlarm missedAlarm)
    {
        try
        {
            await repository.AddAsync(missedAlarm);
            await unitOfWork.CompleteAsync();
            return new MissedAlarmResponse(missedAlarm);
        }
        catch (Exception e)
        {
            return new MissedAlarmResponse($"An error occurred while saving the alarm: {e.Message}");
        }
    }
}