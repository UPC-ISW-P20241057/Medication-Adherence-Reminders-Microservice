using MedicationAdherenceMicroservice.Domain.Models;
using MedicationAdherenceMicroservice.Domain.Repositories;
using MedicationAdherenceMicroservice.Domain.Services;
using MedicationAdherenceMicroservice.Domain.Services.Communication;

namespace MedicationAdherenceMicroservice.Services;

public class ReminderService(IReminderRepository reminderRepository, IUnitOfWork unitOfWork): IReminderService
{
    public async Task<IEnumerable<Reminder>> ListAsync()
    {
        return await reminderRepository.ListAsync();
    }

    public async Task<IEnumerable<Reminder>> ListByUserId(long userId)
    {
        return await reminderRepository.ListByUserId(userId);
    }

    public async Task<ReminderResponse> FindByIdAsync(long id)
    {
        var existingReminder = await reminderRepository.FindByIdAsync(id);
        return existingReminder == null ? new ReminderResponse("Invalid reminder") : new ReminderResponse(existingReminder);
    }

    public async Task<ReminderResponse> SaveAsync(Reminder reminder)
    {
        try
        {
            await reminderRepository.AddAsync(reminder);
            await unitOfWork.CompleteAsync();
            return new ReminderResponse(reminder);
        }
        catch (Exception e)
        {
            return new ReminderResponse($"An error occurred while saving the new reminder: {e.Message}");
        }
    }

    public async Task<ReminderResponse> UpdateAsync(long id, Reminder reminder)
    {
        var existingReminder = await reminderRepository.FindByIdAsync(id);
        if (existingReminder == null)
            return new ReminderResponse("Invalid reminder.");

        existingReminder.Pills = reminder.Pills;
        existingReminder.EndDate = reminder.EndDate;
        existingReminder.ConsumeFood = reminder.ConsumeFood;

        try
        {
            reminderRepository.Update(existingReminder);
            await unitOfWork.CompleteAsync();
            return new ReminderResponse(existingReminder);
        }
        catch (Exception e)
        {
            return new ReminderResponse($"An error occurred while updating the reminder: {e.Message}");
        }
    }

    public async Task<ReminderResponse> DeleteAsync(long id)
    {
        var existingReminder = await reminderRepository.FindByIdAsync(id);
        if (existingReminder == null)
            return new ReminderResponse("Invalid reminder.");

        try
        {
            reminderRepository.Remove(existingReminder);
            await unitOfWork.CompleteAsync();
            return new ReminderResponse(existingReminder);
        }
        catch (Exception e)
        {
            return new ReminderResponse($"An error occurred while deleting the reminder: {e.Message}");
        }
    }
}