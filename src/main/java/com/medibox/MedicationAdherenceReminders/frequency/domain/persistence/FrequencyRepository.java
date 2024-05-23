package com.medibox.MedicationAdherenceReminders.frequency.domain.persistence;

import com.medibox.MedicationAdherenceReminders.frequency.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;
import org.springframework.data.jpa.repository.JpaRepository;

public interface FrequencyRepository extends JpaRepository<Frequency, Long> {
}
