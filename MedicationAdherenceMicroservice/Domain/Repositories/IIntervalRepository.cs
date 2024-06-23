using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IIntervalRepository
{
    Task AddAsync(Interval interval);
    void Update(Interval interval);
}