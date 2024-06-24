using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class ConflictingMedicinesResponse: BaseResponse<ConflictingMedicines>
{
    public ConflictingMedicinesResponse(string message) : base(message)
    {
    }

    public ConflictingMedicinesResponse(ConflictingMedicines resource) : base(resource)
    {
    }
}