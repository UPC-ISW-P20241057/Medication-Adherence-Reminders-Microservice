using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Resources;
using MedicationAdherenceMicroservice.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class IntervalsController(IIntervalService intervalService, IMapper mapper): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveIntervalResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var interval = mapper.Map<SaveIntervalResource, Interval>(resource);
        var result = await intervalService.SaveAsync(interval);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var intervalResource = mapper.Map<Interval, IntervalResource>(result.Resource);
        return Created(nameof(PostAsync), intervalResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(long id, [FromBody] SaveIntervalResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());
        
        var interval = mapper.Map<SaveIntervalResource, Interval>(resource);
        var result = await intervalService.UpdateAsync(id, interval);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var intervalResource = mapper.Map<Interval, IntervalResource>(result.Resource);

        return Ok(intervalResource);
    }
}