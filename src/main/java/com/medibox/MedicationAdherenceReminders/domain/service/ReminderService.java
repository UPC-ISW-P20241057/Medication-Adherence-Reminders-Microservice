package com.medibox.MedicationAdherenceReminders.domain.service;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Reminder;

import java.util.List;
import java.util.Optional;

public interface ReminderService {
  List<Reminder> getAll();
  List<Reminder> getAllByUserId(Long userId);
  Optional<Reminder> getById(Long id);
  Reminder save (Reminder reminder);
  Reminder update (Reminder reminder);
  boolean deleteById (Long id);
}
