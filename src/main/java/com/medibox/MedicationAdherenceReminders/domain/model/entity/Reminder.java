package com.medibox.MedicationAdherenceReminders.domain.model.entity;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.domain.model.entity.Medicine;
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

  @OneToOne(mappedBy = "reminder", cascade = CascadeType.ALL)
  private Frequency frequency;

  @OneToOne(mappedBy = "reminder", cascade = CascadeType.ALL)
  private Interval interval;
  
  @Column(name = "consume_food")
  private Boolean consumeFood;
}
