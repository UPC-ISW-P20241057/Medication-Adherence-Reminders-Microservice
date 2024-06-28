namespace MedicationAdherenceMicroservice.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}