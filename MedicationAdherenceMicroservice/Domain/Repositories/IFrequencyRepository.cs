using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IFrequencyRepository
{
    Task AddAsync(Frequency frequency);
    void Update(Frequency frequency);
}