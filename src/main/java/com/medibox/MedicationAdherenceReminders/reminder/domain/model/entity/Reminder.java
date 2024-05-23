package com.medibox.MedicationAdherenceReminders.reminder.domain.model.entity;

import com.medibox.MedicationAdherenceReminders.frequency.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.interval.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;
import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import lombok.Getter;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@Entity
@Table(name = "reminders")
public class Reminder {
  @Id
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @NotNull
  @Column(name = "created_date", length = 15)
  private Date createdDate;

  @Column(name = "pills")
  private Short pills;

  @Column(name = "end_date")
  private Date endDate;

  @ManyToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "medicine_id", nullable = false)
  private Medicine medicine;

  @NotNull
  @Column(name = "user_id")
  private Long userId;

  @OneToOne(fetch = FetchType.LAZY, cascade = CascadeType.ALL, mappedBy = "reminder")
  private Interval interval;

  @OneToOne(fetch = FetchType.LAZY, cascade = CascadeType.ALL, mappedBy = "reminder")
  private Frequency frequency;
}
