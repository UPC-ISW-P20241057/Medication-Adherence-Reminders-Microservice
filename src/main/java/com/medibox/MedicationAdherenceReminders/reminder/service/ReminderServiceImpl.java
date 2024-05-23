package com.medibox.MedicationAdherenceReminders.reminder.service;

import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;
import com.medibox.MedicationAdherenceReminders.reminder.domain.persistence.ReminderRepository;
import com.medibox.MedicationAdherenceReminders.reminder.domain.service.ReminderService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class ReminderServiceImpl implements ReminderService {

  @Autowired
  private ReminderRepository reminderRepository;

  @Override
  public List<Reminder> getAll() {
    return reminderRepository.findAll();
  }

  @Override
  public Optional<Reminder> getById(Long id) {
    return reminderRepository.findById(id);
  }

  @Override
  public Reminder save(Reminder reminder) {
    return reminderRepository.save(reminder);
  }

  @Override
  public Reminder update(Reminder reminder) {
    return reminderRepository.save(reminder);
  }

  @Override
  public boolean deleteById(Long id) {
    if(reminderRepository.existsById(id)){
      reminderRepository.deleteById(id);
      return true;
    }
    return false;
  }
}
