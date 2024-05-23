package com.medibox.MedicationAdherenceReminders.frequency.mapping;

import com.medibox.MedicationAdherenceReminders.frequency.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.frequency.resource.CreateFrequencyResource;
import com.medibox.MedicationAdherenceReminders.frequency.resource.FrequencyResource;
import com.medibox.MedicationAdherenceReminders.frequency.resource.UpdateFrequencyResource;
import com.medibox.MedicationAdherenceReminders.shared.mapping.EnhancedModelMapper;
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
