using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Resources;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/alarms")]
public class AlarmsController(ICompletedAlarmService completedAlarmService, IMissedAlarmService missedAlarmService, IMapper mapper): ControllerBase
{
    [HttpPost("completed")]
    public async Task<IActionResult> PostCompletedAsync([FromBody] SaveAlarmResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var alarm = mapper.Map<SaveAlarmResource, CompletedAlarm>(resource);
        var result = await completedAlarmService.SaveAsync(alarm);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var alarmResource = mapper.Map<CompletedAlarm, AlarmResource>(result.Resource);

        return Created(nameof(PostCompletedAsync), alarmResource);
    }
    
    [HttpPost("missed")]
    public async Task<IActionResult> PostMissedAsync([FromBody] SaveAlarmResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var alarm = mapper.Map<SaveAlarmResource, MissedAlarm>(resource);
        var result = await missedAlarmService.SaveAsync(alarm);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var alarmResource = mapper.Map<MissedAlarm, AlarmResource>(result.Resource);

        return Created(nameof(PostCompletedAsync), alarmResource);
    }
}