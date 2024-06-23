using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class IntervalResponse: BaseResponse<Interval>
{
    public IntervalResponse(string message) : base(message)
    {
    }

    public IntervalResponse(Interval resource) : base(resource)
    {
    }
}