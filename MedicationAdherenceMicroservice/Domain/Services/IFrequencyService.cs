using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface IFrequencyService
{
    Task<FrequencyResponse> SaveAsync(Frequency frequency);
    Task<FrequencyResponse> UpdateAsync(long id, Frequency frequency);
}