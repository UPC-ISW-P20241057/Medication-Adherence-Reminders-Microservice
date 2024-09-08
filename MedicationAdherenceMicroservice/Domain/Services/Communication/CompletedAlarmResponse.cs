using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class CompletedAlarmResponse: BaseResponse<CompletedAlarm>
{
    public CompletedAlarmResponse(string message) : base(message)
    {
    }

    public CompletedAlarmResponse(CompletedAlarm resource) : base(resource)
    {
    }
}