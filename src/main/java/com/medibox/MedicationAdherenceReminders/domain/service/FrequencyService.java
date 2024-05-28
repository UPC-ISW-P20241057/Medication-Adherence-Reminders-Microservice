package com.medibox.MedicationAdherenceReminders.domain.service;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Frequency;

import java.util.List;

public interface FrequencyService {
  List<Frequency> getAll();
  //Optional<Frequency> getById(Long id);
  Frequency update(Frequency frequency);
  Frequency save(Frequency frequency);
  //boolean deleteById(Long id);
}
