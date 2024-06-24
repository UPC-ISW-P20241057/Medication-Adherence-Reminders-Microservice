using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MedicationAdherenceMicroservice.Persistence.Repositories;

public class ConflictingMedicinesRepository(AppDbContext context): BaseRepository(context), IConflictingMedicinesRepository
{
    public async Task<ConflictingMedicines> FindByMedicineNames(string name1, string name2)
    {
        return await _context.ConflictingMedicinesDbSet
            .FirstOrDefaultAsync(p => (p.Medicine1Name == name1 && p.Medicine2Name == name2) 
                                      || (p.Medicine2Name == name1 && p.Medicine1Name == name2)
                                      );
    }

    public async Task AddAsync(ConflictingMedicines conflictingMedicines)
    {
        await _context.ConflictingMedicinesDbSet.AddAsync(conflictingMedicines);
    }
}