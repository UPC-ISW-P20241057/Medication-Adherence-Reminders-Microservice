package com.medibox.MedicationAdherenceReminders.medicine.domain.service;

import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;

import java.util.List;
import java.util.Optional;

public interface MedicineService {
  List<Medicine> getAll();
  Optional<Medicine> getById(Long id);
  Medicine save(Medicine medicine);
  Medicine update(Medicine medicine);
  boolean deleteById(Long id);
}
