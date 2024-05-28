package com.medibox.MedicationAdherenceReminders.service;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.domain.persistence.IntervalRepository;
import com.medibox.MedicationAdherenceReminders.domain.service.IntervalService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class IntervalServiceImpl implements IntervalService {

  @Autowired
  private IntervalRepository intervalRepository;

  @Override
  public List<Interval> getAll() {
    return intervalRepository.findAll();
  }

  /*@Override
  public Optional<Interval> getById(Long id) {
    return intervalRepository.findById(id);
  }*/

  @Override
  public Interval update(Interval interval) {
    return intervalRepository.save(interval);
  }

  @Override
  public Interval save(Interval interval) {
    return intervalRepository.save(interval);
  }

  /*@Override
  public boolean deleteById(Long id) {
    if(intervalRepository.existsById(id)){
      intervalRepository.deleteById(id);
      return true;
    }
    return false;
  }*/
}