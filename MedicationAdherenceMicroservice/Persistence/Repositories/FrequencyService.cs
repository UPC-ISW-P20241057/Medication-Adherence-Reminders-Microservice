using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class FrequencyService(IFrequencyRepository frequencyRepository, IUnitOfWork unitOfWork): IFrequencyService
{
    public async Task<FrequencyResponse> SaveAsync(Frequency frequency)
    {
        var existingFrequencyWithReminderId = await frequencyRepository.FindByReminderId(frequency.ReminderId);
        if (existingFrequencyWithReminderId != null)
            return new FrequencyResponse("Invalid frequency.");

        try
        {
            await frequencyRepository.AddAsync(frequency);
            await unitOfWork.CompleteAsync();
            return new FrequencyResponse(frequency);
        }
        catch (Exception e)
        {
            return new FrequencyResponse($"An error occurred while saving the new frequency: {e.Message}");
        }
    }

    public async Task<FrequencyResponse> UpdateAsync(long id, Frequency frequency)
    {
        var existingFrequency = await frequencyRepository.FindByIdAsync(id);

        if (existingFrequency == null)
            return new FrequencyResponse("Invalid frequency");

        existingFrequency.FrequencyType = frequency.FrequencyType;
        existingFrequency.Times = frequency.Times;

        try
        {
            frequencyRepository.Update(existingFrequency);
            await unitOfWork.CompleteAsync();
            return new FrequencyResponse(existingFrequency);
        }
        catch (Exception e)
        {
            return new FrequencyResponse($"An error occurred while updating the frequency: {e.Message}");
        }
    }
}