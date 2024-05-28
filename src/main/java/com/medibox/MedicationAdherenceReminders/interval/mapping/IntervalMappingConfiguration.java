package com.medibox.MedicationAdherenceReminders.interval.mapping;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration("intervalMappingConfiguration")
public class IntervalMappingConfiguration {
  @Bean
  public IntervalMapper intervalMapper() {
    return new IntervalMapper();
  }
}
