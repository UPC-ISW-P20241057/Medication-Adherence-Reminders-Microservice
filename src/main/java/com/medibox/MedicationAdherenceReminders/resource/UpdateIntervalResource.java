package com.medibox.MedicationAdherenceReminders.resource;

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
public class UpdateIntervalResource {

  @NotNull
  private Long id;

  @NotNull
  private String intervalType;

  @NotNull
  private Integer interval;
}