using MedicationAdherenceMicroservice.Persistence.Context;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public abstract class BaseRepository(AppDbContext context)
{
    protected readonly AppDbContext _context = context;
}