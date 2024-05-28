package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.resource.CreateIntervalResource;
import com.medibox.MedicationAdherenceReminders.resource.IntervalResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateIntervalResource;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;

public class IntervalMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;

  public Interval toModel(CreateIntervalResource resource) {
    return this.mapper.map(resource, Interval.class);
  }
  public Interval toModel(UpdateIntervalResource resource) {
    return this.mapper.map(resource, Interval.class);
  }
  public IntervalResource toResource(Interval interval) {
    return this.mapper.map(interval, IntervalResource.class);
  }
}
