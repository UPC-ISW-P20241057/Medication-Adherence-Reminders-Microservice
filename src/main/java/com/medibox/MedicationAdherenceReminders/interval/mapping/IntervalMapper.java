package com.medibox.MedicationAdherenceReminders.interval.mapping;

import com.medibox.MedicationAdherenceReminders.interval.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.interval.resource.CreateIntervalResource;
import com.medibox.MedicationAdherenceReminders.interval.resource.IntervalResource;
import com.medibox.MedicationAdherenceReminders.interval.resource.UpdateIntervalResource;
import com.medibox.MedicationAdherenceReminders.medicine.resource.CreateMedicineResource;
import com.medibox.MedicationAdherenceReminders.medicine.resource.UpdateMedicineResource;
import com.medibox.MedicationAdherenceReminders.shared.mapping.EnhancedModelMapper;
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
