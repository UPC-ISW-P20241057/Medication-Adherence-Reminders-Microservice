package com.medibox.MedicationAdherenceReminders.domain.persistence;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Frequency;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface FrequencyRepository extends JpaRepository<Frequency, Long> {
}
