package com.medibox.MedicationAdherenceReminders.mapping;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration("mappingConfiguration")
public class MappingConfiguration {
    @Bean
    public FrequencyMapper frequencyMapper(){
        return new FrequencyMapper();
    } 
    @Bean
    public EnhancedModelMapper modelMapper() {
        return new EnhancedModelMapper();
    }
    @Bean
    public IntervalMapper intervalMapper() {
        return new IntervalMapper();
    }
    @Bean
    public MedicineMapper medicineMapper() {
        return new MedicineMapper();
    }
    @Bean
    public ReminderMapper reminderMapper(){
        return new ReminderMapper();
    }
}
