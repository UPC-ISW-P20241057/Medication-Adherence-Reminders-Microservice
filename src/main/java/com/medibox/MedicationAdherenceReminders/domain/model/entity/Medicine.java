package com.medibox.MedicationAdherenceReminders.domain.model.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotNull;
import lombok.Getter;
import lombok.Setter;

import java.util.List;

@Getter
@Setter
@Entity
@Table(name = "medicines")
public class Medicine {
  @Id
  @GeneratedValue(strategy = GenerationType.IDENTITY)
  private Long id;

  @NotNull
  @Column(name = "name", length = 50)
  private String name;

  @NotNull
  @Column(name = "type", length = 10)
  private String type;

  @OneToMany(mappedBy = "medicine", cascade = CascadeType.ALL, orphanRemoval = true)
  private List<Reminder> reminders;
}
