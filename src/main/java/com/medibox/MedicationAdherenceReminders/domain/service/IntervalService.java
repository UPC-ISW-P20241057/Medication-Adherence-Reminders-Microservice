package com.medibox.MedicationAdherenceReminders.domain.service;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Interval;

import java.util.List;

public interface IntervalService {
  List<Interval> getAll();
  //Optional<Interval> getById(Reminder id);
  Interval update(Interval interval);
  Interval save(Interval interval);
  //boolean deleteById(Reminder id);
}
