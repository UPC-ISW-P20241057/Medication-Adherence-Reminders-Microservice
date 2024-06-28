using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class FrequencyResponse: BaseResponse<Frequency>
{
    public FrequencyResponse(string message) : base(message)
    {
    }

    public FrequencyResponse(Frequency resource) : base(resource)
    {
    }
}