package com.medibox.MedicationAdherenceReminders.medicine.resource;

import jakarta.validation.constraints.NotNull;
import lombok.*;

@Getter
@Setter
@With
@NoArgsConstructor
@AllArgsConstructor
public class UpdateMedicineResource {
  @NotNull
  private Long id;

  @NotNull
  private String name;

  @NotNull
  private String type;
}
