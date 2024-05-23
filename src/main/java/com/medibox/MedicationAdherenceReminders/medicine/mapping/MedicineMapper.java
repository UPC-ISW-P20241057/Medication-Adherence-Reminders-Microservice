package com.medibox.MedicationAdherenceReminders.medicine.mapping;

import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;
import com.medibox.MedicationAdherenceReminders.medicine.resource.CreateMedicineResource;
import com.medibox.MedicationAdherenceReminders.medicine.resource.MedicineResource;
import com.medibox.MedicationAdherenceReminders.medicine.resource.UpdateMedicineResource;
import org.springframework.beans.factory.annotation.Autowired;
import com.medibox.MedicationAdherenceReminders.shared.mapping.EnhancedModelMapper;

import java.io.Serializable;

public class MedicineMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;

  public Medicine toModel(CreateMedicineResource resource) {
    return this.mapper.map(resource, Medicine.class);
  }
  public Medicine toModel(UpdateMedicineResource resource) {
    return this.mapper.map(resource, Medicine.class);
  }
  public MedicineResource toResource(Medicine medicine) {
    return this.mapper.map(medicine, MedicineResource.class);
  }
}
