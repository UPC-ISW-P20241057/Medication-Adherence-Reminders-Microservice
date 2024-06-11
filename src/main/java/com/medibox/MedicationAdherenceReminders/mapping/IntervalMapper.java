package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.domain.persistence.ReminderRepository;
import com.medibox.MedicationAdherenceReminders.resource.CreateIntervalResource;
import com.medibox.MedicationAdherenceReminders.resource.IntervalResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateIntervalResource;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;

public class IntervalMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;
  
  @Autowired
  ReminderRepository reminderRepository;

  public Interval toModel(CreateIntervalResource resource) {
    Interval interval = new Interval();
    interval.setReminder(reminderRepository.getById(resource.getReminderId()));
    interval.setIntervalType(resource.getIntervalType());
    interval.setInterval(resource.getInterval());
    return interval;
  }
  public Interval toModel(UpdateIntervalResource resource) {
    Interval interval = new Interval();
    interval.setId(resource.getId());
    interval.setIntervalType(resource.getIntervalType());
    interval.setInterval(resource.getInterval());
    return interval;
  }
  public IntervalResource toResource(Interval interval) {
    return this.mapper.map(interval, IntervalResource.class);
  }
}
