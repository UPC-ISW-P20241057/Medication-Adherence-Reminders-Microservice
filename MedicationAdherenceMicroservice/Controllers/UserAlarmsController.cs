using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Resources;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/users/{userId}/alarms")]
public class UserAlarmsController(ICompletedAlarmService completedAlarmService, IMissedAlarmService missedAlarmService, IMapper mapper): ControllerBase
{
    [HttpGet("completed")]
    public async Task<IEnumerable<AlarmResource>> GetAllCompletedAlarmsByUserId(long userId)
    {
        var alarms = await completedAlarmService.ListByUserId(userId);
        var resources = mapper.Map<IEnumerable<CompletedAlarm>, IEnumerable<AlarmResource>>(alarms);
        return resources;
    }
    
    [HttpGet("missed")]
    public async Task<IEnumerable<AlarmResource>> GetAllMissedAlarmsByUserId(long userId)
    {
        var alarms = await missedAlarmService.ListByUserId(userId);
        var resources = mapper.Map<IEnumerable<MissedAlarm>, IEnumerable<AlarmResource>>(alarms);
        return resources;
    }

    
}