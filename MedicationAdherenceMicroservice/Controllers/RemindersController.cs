using AutoMapper;
using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Extensions;
using MedicationAdherenceMicroservice.Resources;
using Microsoft.AspNetCore.Mvc;

namespace MedicationAdherenceMicroservice.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class RemindersController(IReminderService reminderService, IMapper mapper): ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<ReminderResource>> GetAllAsync()
    {
        var reminders = await reminderService.ListAsync();
        var resources = mapper.Map<IEnumerable<Reminder>, IEnumerable<ReminderResource>>(reminders);
        return resources;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var result = await reminderService.FindByIdAsync(id);

        if (!result.Success)
            return BadRequest(result.Message);

        var resource = mapper.Map<Reminder, ReminderResource>(result.Resource);
        return Ok(resource);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveReminderResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var reminder = mapper.Map<SaveReminderResource, Reminder>(resource);
        var result = await reminderService.SaveAsync(reminder);
        
        if (!result.Success)
            return BadRequest(result.Message);

        var reminderResource = mapper.Map<Reminder, ReminderResource>(result.Resource);

        return Created(nameof(PostAsync), reminderResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(long id, [FromBody] SaveReminderResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var reminder = mapper.Map<SaveReminderResource, Reminder>(resource);
        var result = await reminderService.UpdateAsync(id, reminder);
        
        if (!result.Success)
            return BadRequest(result.Message);
        
        var reminderResource = mapper.Map<Reminder, ReminderResource>(result.Resource);

        return Ok(reminderResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        var result = await reminderService.DeleteAsync(id);
        
        if (!result.Success)
            return BadRequest(result.Message);
        
        var reminderResource = mapper.Map<Reminder, ReminderResource>(result.Resource);

        return Ok(reminderResource);
    }
}