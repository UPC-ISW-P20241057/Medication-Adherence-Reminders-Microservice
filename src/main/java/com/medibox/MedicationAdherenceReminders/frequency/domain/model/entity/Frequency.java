package com.medibox.MedicationAdherenceReminders.frequency.domain.model.entity;

import com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity.Reminder;
import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "frequencies")
public class Frequency {
  @Id
  private Long reminderId;

  @OneToOne(fetch = FetchType.LAZY)
  @MapsId
  @JoinColumn(name = "reminder_id", nullable = false)
  private Reminder reminder;

  @NotNull
  @Column(name = "frequency_type", length = 15)
  private String frequencyType;

  @NotNull
  @Column(name = "times")
  private Integer times;
}
