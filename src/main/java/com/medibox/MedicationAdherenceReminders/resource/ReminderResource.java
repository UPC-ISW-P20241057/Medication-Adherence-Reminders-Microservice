package com.medibox.MedicationAdherenceReminders.resource;

import jakarta.validation.constraints.NotNull;
import lombok.*;

import java.util.Date;

@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@With
public class ReminderResource {
  private Long id;

  @NotNull
  private Date createdDate;

  private Short pills;

  private Date endDate;

  @NotNull
  private MedicineResource medicine;

  @NotNull
  private Long userId;
  
  private FrequencyResource frequency;
  private IntervalResource interval;

  private Boolean consumeFood;
}
