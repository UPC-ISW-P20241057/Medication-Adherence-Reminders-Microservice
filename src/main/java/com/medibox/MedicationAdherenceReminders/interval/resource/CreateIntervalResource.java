package com.medibox.MedicationAdherenceReminders.interval.resource;

import jakarta.persistence.Column;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.validation.constraints.NotNull;
import lombok.*;

@Getter
@Setter
@With
@NoArgsConstructor
@AllArgsConstructor
public class CreateIntervalResource {

  @NotNull
  private String intervalType;

  @NotNull
  private Integer interval;
}
