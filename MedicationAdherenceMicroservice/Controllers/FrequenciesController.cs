using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Resources;
using MedicationAdherenceMicroservice.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class FrequenciesController(IFrequencyService frequencyService, IMapper mapper): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveFrequencyResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var frequency = mapper.Map<SaveFrequencyResource, Frequency>(resource);
        var result = await frequencyService.SaveAsync(frequency);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var frequencyResource = mapper.Map<Frequency, FrequencyResource>(result.Resource);
        return Created(nameof(PostAsync), frequencyResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(long id, [FromBody] SaveFrequencyResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var frequency = mapper.Map<SaveFrequencyResource, Frequency>(resource);
        var result = await frequencyService.UpdateAsync(id, frequency);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var frequencyResource = mapper.Map<Frequency, FrequencyResource>(result.Resource);

        return Ok(frequencyResource);
    }
}