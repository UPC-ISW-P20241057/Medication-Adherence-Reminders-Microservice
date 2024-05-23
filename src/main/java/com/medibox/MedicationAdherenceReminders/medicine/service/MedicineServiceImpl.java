package com.medibox.MedicationAdherenceReminders.medicine.service;

import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;
import com.medibox.MedicationAdherenceReminders.medicine.domain.persistence.MedicineRepository;
import com.medibox.MedicationAdherenceReminders.medicine.domain.service.MedicineService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class MedicineServiceImpl implements MedicineService {

  @Autowired
  private MedicineRepository medicineRepository;

  @Override
  public List<Medicine> getAll() {
    return medicineRepository.findAll();
  }

  @Override
  public Optional<Medicine> getById(Long id) {
    return medicineRepository.findById(id);
  }

  @Override
  public Medicine save(Medicine medicine) {
    return medicineRepository.save(medicine);
  }

  @Override
  public Medicine update(Medicine medicine) {
    return medicineRepository.save(medicine);
  }

  @Override
  public boolean deleteById(Long id) {
    if (medicineRepository.existsById(id)) {
      medicineRepository.deleteById(id);
      return true;
    }
    return false;
  }
}
