package com.medibox.MedicationAdherenceReminders.resource;

import jakarta.validation.constraints.NotNull;
import lombok.*;

import java.security.KeyStore;

@Getter
@Setter
@With
@NoArgsConstructor
@AllArgsConstructor
public class CreateMedicineResource {
  @NotNull
  private Long reminderId;
  
  @NotNull
  private String name;

  @NotNull
  private String type;
}
