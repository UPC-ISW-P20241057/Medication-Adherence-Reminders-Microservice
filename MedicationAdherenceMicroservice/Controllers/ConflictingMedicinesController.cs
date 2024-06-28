using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Queries;
using MedicationAdherenceMicroservice.Resources;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ConflictingMedicinesController(IConflictingMedicinesService service, IMapper mapper): ControllerBase
{
    [HttpPatch]
    public async Task<IActionResult> FindByNamesAsync([FromBody] FindByNamesQuery query)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var result = await service.FindByMedicineNamesAsync(query.Name1, query.Name2);

        if (!result.Success)
            return BadRequest(result.Message);

        var resource = mapper.Map<ConflictingMedicines, ConflictingMedicinesResource>(result.Resource);
        return Ok(resource);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveConflictingMedicinesResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var model = mapper.Map<SaveConflictingMedicinesResource, ConflictingMedicines>(resource);
        var result = await service.SaveAsync(model);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var finalResource = mapper.Map<ConflictingMedicines, ConflictingMedicinesResource>(result.Resource);
        return Created(nameof(PostAsync), finalResource);
    }
}