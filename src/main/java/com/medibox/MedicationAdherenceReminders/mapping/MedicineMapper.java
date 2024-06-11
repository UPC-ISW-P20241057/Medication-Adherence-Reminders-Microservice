package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Medicine;
import com.medibox.MedicationAdherenceReminders.resource.CreateMedicineResource;
import com.medibox.MedicationAdherenceReminders.resource.MedicineResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateMedicineResource;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;
import java.util.List;

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
  public List<MedicineResource> toResourceList(List<Medicine> medicines) {
    return this.mapper.mapList(medicines, MedicineResource.class);
  }
}
