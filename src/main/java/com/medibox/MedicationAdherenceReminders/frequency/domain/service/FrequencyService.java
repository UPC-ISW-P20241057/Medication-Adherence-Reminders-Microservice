package com.medibox.MedicationAdherenceReminders.frequency.domain.service;

import com.medibox.MedicationAdherenceReminders.frequency.domain.model.entity.Frequency;

import java.util.List;
import java.util.Optional;

public interface FrequencyService {
  List<Frequency> getAll();
  //Optional<Frequency> getById(Long id);
  Frequency update(Frequency frequency);
  Frequency save(Frequency frequency);
  //boolean deleteById(Long id);
}
