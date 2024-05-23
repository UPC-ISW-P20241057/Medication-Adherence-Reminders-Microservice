package com.medibox.MedicationAdherenceReminders.reminder.mapping;

import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;
import com.medibox.MedicationAdherenceReminders.reminder.resource.CreateReminderResource;
import com.medibox.MedicationAdherenceReminders.reminder.resource.ReminderResource;
import com.medibox.MedicationAdherenceReminders.reminder.resource.UpdateReminderResource;
import com.medibox.MedicationAdherenceReminders.shared.mapping.EnhancedModelMapper;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;

public class ReminderMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;

  public Reminder toModel(CreateReminderResource resource) {
    return this.mapper.map(resource, Reminder.class);
  }
  public Reminder toModel(UpdateReminderResource resource) {
    return this.mapper.map(resource, Reminder.class);
  }
  public ReminderResource toResource(Reminder reminder) {
    return this.mapper.map(reminder, ReminderResource.class);
  }
}
