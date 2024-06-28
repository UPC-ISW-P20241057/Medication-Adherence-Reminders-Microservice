using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IFrequencyRepository
{
    Task<Frequency> FindByIdAsync(long id);
    Task<Frequency> FindByReminderId(long reminderId);
    Task AddAsync(Frequency frequency);
    void Update(Frequency frequency);
}