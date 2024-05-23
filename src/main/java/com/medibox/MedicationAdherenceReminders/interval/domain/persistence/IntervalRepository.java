package com.medibox.MedicationAdherenceReminders.interval.domain.persistence;

import com.medibox.MedicationAdherenceReminders.interval.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IntervalRepository extends JpaRepository<Interval, Long> {
}
