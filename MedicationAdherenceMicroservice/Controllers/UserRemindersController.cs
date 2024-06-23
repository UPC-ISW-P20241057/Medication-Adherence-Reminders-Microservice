using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Resources;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/users/{userId}/reminders")]
public class UserRemindersController(IReminderService reminderService, IMapper mapper): ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<ReminderResource>> GetAllRemindersByUserId(long userId)
    {
        var reminders = await reminderService.ListByUserId(userId);
        var resources = mapper.Map<IEnumerable<Reminder>, IEnumerable<ReminderResource>>(reminders);
        return resources;
    }
}