package com.medibox.MedicationAdherenceReminders.domain.persistence;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Medicine;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MedicineRepository extends JpaRepository<Medicine, Long> {
}