package com.medibox.MedicationAdherenceReminders.mapping;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Reminder;
import com.medibox.MedicationAdherenceReminders.domain.persistence.MedicineRepository;
import com.medibox.MedicationAdherenceReminders.resource.CreateReminderResource;
import com.medibox.MedicationAdherenceReminders.resource.ReminderResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateReminderResource;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class ReminderMapper implements Serializable {
  @Autowired
  EnhancedModelMapper mapper;
  
  @Autowired
  MedicineRepository medicineRepository;

  public Reminder toModel(CreateReminderResource resource) {
    Reminder reminder = new Reminder();
    reminder.setCreatedDate(resource.getCreatedDate());
    reminder.setPills(resource.getPills());
    reminder.setEndDate(resource.getEndDate());
    reminder.setMedicine(medicineRepository.getById(resource.getMedicineId()));
    reminder.setUserId(resource.getUserId());
    reminder.setConsumeFood(resource.getConsumeFood());
    return reminder;
  }
  public Reminder toModel(UpdateReminderResource resource) {
    Reminder reminder = new Reminder();
    reminder.setId(resource.getId());
    reminder.setCreatedDate(resource.getCreatedDate());
    reminder.setPills(resource.getPills());
    reminder.setEndDate(resource.getEndDate());
    reminder.setMedicine(medicineRepository.getById(resource.getMedicineId()));
    reminder.setUserId(resource.getUserId());
    reminder.setConsumeFood(resource.getConsumeFood());
    return reminder;
  }
  public ReminderResource toResource(Reminder reminder) {
    return this.mapper.map(reminder, ReminderResource.class);
  }
  public List<ReminderResource> toResourceList(List<Reminder> reminders) {
    return this.mapper.mapList(reminders, ReminderResource.class);
  }
}
