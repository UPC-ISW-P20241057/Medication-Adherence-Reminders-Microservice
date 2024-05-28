package com.medibox.MedicationAdherenceReminders.domain.model.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "intervals")
public class Interval {
  @Id
  private Long reminderId;

  @MapsId
  @OneToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "reminder_id", nullable = false)
  private Reminder reminder;

  @NotNull
  @Column(name = "interval_type", length = 15)
  private String intervalType;

  @NotNull
  @Column(name = "interval")
  private Integer interval;
}
