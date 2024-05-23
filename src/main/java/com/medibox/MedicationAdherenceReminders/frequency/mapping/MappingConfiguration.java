package com.medibox.MedicationAdherenceReminders.frequency.mapping;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration("frequencyMappingConfiguration")
public class MappingConfiguration {
  @Bean
  public FrequencyMapper frequencyMapper(){
    return new FrequencyMapper();
  }
}
