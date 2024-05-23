package com.medibox.MedicationAdherenceReminders.interval.domain.service;

import com.medibox.MedicationAdherenceReminders.interval.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;

import java.util.List;
import java.util.Optional;

public interface IntervalService {
  List<Interval> getAll();
  //Optional<Interval> getById(Reminder id);
  Interval update(Interval interval);
  Interval save(Interval interval);
  //boolean deleteById(Reminder id);
}
