package com.medibox.MedicationAdherenceReminders.conflictingmedicine.domain.model.entity;

import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;
import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "conflicting_medicines")
public class ConflictingMedicine {
  /*@Id
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;*/

  @Id
  @ManyToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "medicine1_id", nullable = false)
  private Medicine medicine1Id;

  @Id
  @ManyToOne(fetch = FetchType.LAZY)
  @JoinColumn(name = "medicine2_id", nullable = false)
  private Medicine medicine2Id;

  @NotNull
  @Column(name = "danger_level")
  private Short dangerLevel;
}
