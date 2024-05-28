package com.medibox.MedicationAdherenceReminders.service;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.domain.persistence.FrequencyRepository;
import com.medibox.MedicationAdherenceReminders.domain.service.FrequencyService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class FrequencyServiceImpl implements FrequencyService {

  @Autowired
  private FrequencyRepository frequencyRepository;

  @Override
  public List<Frequency> getAll() {
    return frequencyRepository.findAll();
  }

  /*@Override
  public Optional<Frequency> getById(Long id) {
    return frequencyRepository.findById(id);
  }*/

  @Override
  public Frequency update(Frequency frequency) {
    return frequencyRepository.save(frequency);
  }

  @Override
  public Frequency save(Frequency frequency) {
    return frequencyRepository.save(frequency);
  }

  /*@Override
  public boolean deleteById(Long id) {
    if(frequencyRepository.existsById(id)){
      frequencyRepository.deleteById(id);
      return true;
    }
    return false;
  }*/
}
