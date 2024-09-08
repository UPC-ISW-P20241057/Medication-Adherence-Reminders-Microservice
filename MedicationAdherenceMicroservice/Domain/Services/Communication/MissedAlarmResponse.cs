using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class MissedAlarmResponse: BaseResponse<MissedAlarm>
{
    public MissedAlarmResponse(string message) : base(message)
    {
    }

    public MissedAlarmResponse(MissedAlarm resource) : base(resource)
    {
    }
}