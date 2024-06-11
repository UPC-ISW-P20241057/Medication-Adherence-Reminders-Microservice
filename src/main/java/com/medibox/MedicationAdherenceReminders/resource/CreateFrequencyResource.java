package com.medibox.MedicationAdherenceReminders.resource;

import jakarta.validation.constraints.NotNull;
import lombok.*;

@Getter
@Setter
@With
@AllArgsConstructor
@NoArgsConstructor
public class CreateFrequencyResource {
  @NotNull
  private Long reminderId;

  @NotNull
  private String frequencyType;

  @NotNull
  private Integer times;
}
