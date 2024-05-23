package com.medibox.MedicationAdherenceReminders.reminder.domain.persistence;

import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ReminderRepository extends JpaRepository<Reminder, Long> {
}
