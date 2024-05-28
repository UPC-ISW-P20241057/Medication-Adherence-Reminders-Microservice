package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.resource.CreateFrequencyResource;
import com.medibox.MedicationAdherenceReminders.resource.FrequencyResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateFrequencyResource;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;

public class FrequencyMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;

  public Frequency toModel(CreateFrequencyResource resource) {
    return this.mapper.map(resource, Frequency.class);
  }
  public Frequency toModel(UpdateFrequencyResource resource) {
    return this.mapper.map(resource, Frequency.class);
  }
  public FrequencyResource toResource(Frequency frequency) {
    return this.mapper.map(frequency, FrequencyResource.class);
  }
}
