package com.medibox.MedicationAdherenceReminders.reminder.domain.service;

import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;

import java.util.List;
import java.util.Optional;

public interface ReminderService {
  List<Reminder> getAll();
  Optional<Reminder> getById(Long id);
  Reminder save (Reminder reminder);
  Reminder update (Reminder reminder);
  boolean deleteById (Long id);
}
