using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Services;

public class CompletedAlarmService(ICompletedAlarmRepository repository, IUnitOfWork unitOfWork): ICompletedAlarmService
{
    public async Task<IEnumerable<CompletedAlarm>> ListByUserId(long userId)
    {
        return await repository.ListByUserId(userId);
    }

    public async Task<CompletedAlarmResponse> SaveAsync(CompletedAlarm completedAlarm)
    {
        try
        {
            await repository.AddAsync(completedAlarm);
            await unitOfWork.CompleteAsync();
            return new CompletedAlarmResponse(completedAlarm);
        }
        catch (Exception e)
        {
            return new CompletedAlarmResponse($"An error occurred while saving the alarm: {e.Message}");
        }
    }
}