package com.medibox.MedicationAdherenceReminders.reminder.mapping;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration("reminderMappingConfiguration")
public class MappingConfiguration {
  @Bean
  public ReminderMapper reminderMapper(){
    return new ReminderMapper();
  }
}
