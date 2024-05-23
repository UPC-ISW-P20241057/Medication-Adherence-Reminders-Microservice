package com.medibox.MedicationAdherenceReminders.interval.mapping;

import com.medibox.MedicationAdherenceReminders.medicine.mapping.MedicineMapper;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration("intervalMappingConfiguration")
public class MappingConfiguration {
  @Bean
  public IntervalMapper intervalMapper() {
    return new IntervalMapper();
  }
}
