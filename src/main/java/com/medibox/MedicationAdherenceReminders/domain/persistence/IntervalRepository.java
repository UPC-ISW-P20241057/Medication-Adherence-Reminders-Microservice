package com.medibox.MedicationAdherenceReminders.domain.persistence;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Interval;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IntervalRepository extends JpaRepository<Interval, Long> {
}
