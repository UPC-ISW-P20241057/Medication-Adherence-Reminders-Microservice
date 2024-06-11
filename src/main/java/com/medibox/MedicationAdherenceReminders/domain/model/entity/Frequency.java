package com.medibox.MedicationAdherenceReminders.domain.model.entity;

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
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @NotNull
  @Column(name = "frequency_type", length = 15)
  private String frequencyType;

  @NotNull
  @Column(name = "times")
  private Integer times;

  @OneToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "reminder_id", nullable = false)
  private Reminder reminder;
}
