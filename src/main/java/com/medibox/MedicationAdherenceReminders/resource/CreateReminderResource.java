package com.medibox.MedicationAdherenceReminders.resource;

import jakarta.validation.constraints.NotNull;
import lombok.*;

import java.util.Date;

@AllArgsConstructor
@NoArgsConstructor
@Getter
@Setter
@With
public class CreateReminderResource {

  @NotNull
  private Date createdDate;

  private Short pills;

  private Date endDate;

  @NotNull
  private Long medicineId;

  @NotNull
  private Long userId;

  private Boolean consumeFood;
}
