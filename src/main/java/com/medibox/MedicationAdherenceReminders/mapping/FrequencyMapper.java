package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.domain.persistence.ReminderRepository;
import com.medibox.MedicationAdherenceReminders.resource.CreateFrequencyResource;
import com.medibox.MedicationAdherenceReminders.resource.FrequencyResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateFrequencyResource;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;

public class FrequencyMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;
  
  @Autowired
  ReminderRepository reminderRepository;

  public Frequency toModel(CreateFrequencyResource resource) {
    Frequency frequency = new Frequency();
    frequency.setReminder(reminderRepository.getById(resource.getReminderId()));
    frequency.setFrequencyType(resource.getFrequencyType());
    frequency.setTimes(resource.getTimes());
    return frequency;
  }
  public Frequency toModel(UpdateFrequencyResource resource) {
    Frequency frequency = new Frequency();
    frequency.setId(resource.getId());
    frequency.setFrequencyType(resource.getFrequencyType());
    frequency.setTimes(resource.getTimes());
    return frequency;
  }
  public FrequencyResource toResource(Frequency frequency) {
    return this.mapper.map(frequency, FrequencyResource.class);
  }
}
