using MedicationAdherenceMicroservice.Domain.Models;

namespace MedicationAdherenceMicroservice.Domain.Services.Communication;

public class ReminderResponse: BaseResponse<Reminder>
{
    public ReminderResponse(string message) : base(message)
    {
    }

    public ReminderResponse(Reminder resource) : base(resource)
    {
    }
}