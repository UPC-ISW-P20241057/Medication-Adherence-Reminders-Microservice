package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Reminder;
import com.medibox.MedicationAdherenceReminders.resource.CreateReminderResource;
import com.medibox.MedicationAdherenceReminders.resource.ReminderResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateReminderResource;
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
