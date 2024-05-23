package com.medibox.MedicationAdherenceReminders.medicine.mapping;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration("medicineMappingConfiguration")
public class MappingConfiguration {
  @Bean
  public MedicineMapper medicineMapper() {
    return new MedicineMapper();
  }
}
