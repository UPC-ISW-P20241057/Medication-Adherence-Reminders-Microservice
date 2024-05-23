package com.medibox.MedicationAdherenceReminders.frequency.resource;

import jakarta.validation.constraints.NotNull;
import lombok.*;

@Getter
@Setter
@With
@AllArgsConstructor
@NoArgsConstructor
public class CreateFrequencyResource {

  @NotNull
  private String frequencyType;

  @NotNull
  private Integer times;
}
