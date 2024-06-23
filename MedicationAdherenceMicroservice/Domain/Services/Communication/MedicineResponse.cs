using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class MedicineResponse: BaseResponse<Medicine>
{
    public MedicineResponse(string message) : base(message)
    {
    }

    public MedicineResponse(Medicine resource) : base(resource)
    {
    }
}