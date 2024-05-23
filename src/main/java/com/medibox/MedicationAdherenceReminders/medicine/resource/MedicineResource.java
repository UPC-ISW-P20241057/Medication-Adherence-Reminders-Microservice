package com.medibox.MedicationAdherenceReminders.medicine.resource;

import jakarta.persistence.Column;
import lombok.*;

@Getter
@Setter
@With
@NoArgsConstructor
@AllArgsConstructor
public class MedicineResource {
  private Long id;

  private String name;

  private String type;
}
