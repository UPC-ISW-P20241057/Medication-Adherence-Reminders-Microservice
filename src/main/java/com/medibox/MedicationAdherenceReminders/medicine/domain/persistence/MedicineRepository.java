package com.medibox.MedicationAdherenceReminders.medicine.domain.persistence;

import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MedicineRepository extends JpaRepository<Medicine, Long> {
}
