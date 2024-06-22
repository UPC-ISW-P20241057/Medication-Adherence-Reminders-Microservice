package com.medibox.MedicationAdherenceReminders.api;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Reminder;
import com.medibox.MedicationAdherenceReminders.domain.service.ReminderService;
import com.medibox.MedicationAdherenceReminders.mapping.ReminderMapper;
import com.medibox.MedicationAdherenceReminders.resource.ReminderResource;
import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("api/v1/users/{id}/reminders")
public class UserRemindersController {
    private final ReminderService reminderService;
    private final ReminderMapper mapper;
    
    @GetMapping
    public List<ReminderResource> getUserReminders(@PathVariable Long id) {
        return mapper.toResourceList(reminderService.getAllByUserId(id));
    }
}
