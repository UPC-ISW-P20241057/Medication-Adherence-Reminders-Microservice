using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Resources;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class MedicinesController(IMedicineService medicineService, IMapper mapper): ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<MedicineResource>> GetAllAsync()
    {
        var medicines = await medicineService.ListAsync();
        var resources = mapper.Map<IEnumerable<Medicine>, IEnumerable<MedicineResource>>(medicines);
        return resources;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var result = await medicineService.FindByIdAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var resource = mapper.Map<Medicine, MedicineResource>(result.Resource);
        return Ok(resource);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveMedicineResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var medicine = mapper.Map<SaveMedicineResource, Medicine>(resource);
        var result = await medicineService.SaveAsync(medicine);

        if (!result.Success)
            return BadRequest(result.Message);

        var medicineResource = mapper.Map<Medicine, MedicineResource>(result.Resource);

        return Created(nameof(PostAsync), medicineResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(long id, [FromBody] SaveMedicineResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());
        
        var medicine = mapper.Map<SaveMedicineResource, Medicine>(resource);
        var result = await medicineService.UpdateAsync(id, medicine);
        
        if (!result.Success)
            return BadRequest(result.Message);
        
        var medicineResource = mapper.Map<Medicine, MedicineResource>(result.Resource);

        return Ok(medicineResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        var result = await medicineService.DeleteAsync(id);
        
        if (!result.Success)
            return BadRequest(result.Message);
        
        var medicineResource = mapper.Map<Medicine, MedicineResource>(result.Resource);

        return Ok(medicineResource);
    }
}