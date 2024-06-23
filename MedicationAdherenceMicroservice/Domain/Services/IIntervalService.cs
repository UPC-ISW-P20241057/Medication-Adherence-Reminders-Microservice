using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Domain.Services;

public interface IIntervalService
{
    Task<IntervalResponse> SaveAsync(Interval interval);
    Task<IntervalResponse> UpdateAsync(long id, Interval interval);
}