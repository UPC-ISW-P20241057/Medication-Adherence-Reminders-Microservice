using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Services;

public class IntervalService(IIntervalRepository intervalRepository, IUnitOfWork unitOfWork): IIntervalService
{
    public async Task<IntervalResponse> SaveAsync(Interval interval)
    {
        var existingIntervalWithReminderId = await intervalRepository.FindByReminderIdAsync(interval.ReminderId);
        if (existingIntervalWithReminderId != null)
            return new IntervalResponse("Invalid interval.");

        try
        {
            await intervalRepository.AddAsync(interval);
            await unitOfWork.CompleteAsync();
            return new IntervalResponse(interval);
        }
        catch (Exception e)
        {
            return new IntervalResponse($"An error occurred while saving the new interval: {e.Message}");
        }
    }

    public async Task<IntervalResponse> UpdateAsync(long id, Interval interval)
    {
        var existingInterval = await intervalRepository.FindByIdAsync(id);

        if (existingInterval == null)
            return new IntervalResponse("Invalid interval.");

        existingInterval.IntervalType = interval.IntervalType;
        existingInterval.Value = interval.Value;

        try
        {
            intervalRepository.Update(existingInterval);
            await unitOfWork.CompleteAsync();
            return new IntervalResponse(existingInterval);
        }
        catch (Exception e)
        {
            return new IntervalResponse($"An error occurred while updating the interval: {e.Message}");
        }
    }
}