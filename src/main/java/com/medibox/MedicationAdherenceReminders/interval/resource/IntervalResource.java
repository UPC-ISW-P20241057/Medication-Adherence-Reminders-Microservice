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
public class IntervalResource {

  @NotNull
  private Long id;

  @NotNull
  private String intervalType;

  @NotNull
  private Integer interval;
}
