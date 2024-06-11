package com.medibox.MedicationAdherenceReminders.domain.model.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "reminder_intervals")
public class Interval {
  @Id
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @NotNull
  @Column(name = "interval_type", length = 15)
  private String intervalType;

  @NotNull
  @Column(name = "interval_value")
  private Integer interval;

  @OneToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "reminder_id", nullable = false)
  private Reminder reminder;
}
