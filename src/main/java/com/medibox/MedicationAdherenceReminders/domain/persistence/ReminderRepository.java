package com.medibox.MedicationAdherenceReminders.domain.persistence;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Reminder;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ReminderRepository extends JpaRepository<Reminder, Long> {
}
