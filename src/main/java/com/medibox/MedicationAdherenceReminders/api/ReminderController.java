package com.medibox.MedicationAdherenceReminders.api;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Reminder;
import com.medibox.MedicationAdherenceReminders.domain.service.ReminderService;
import com.medibox.MedicationAdherenceReminders.mapping.ReminderMapper;
import com.medibox.MedicationAdherenceReminders.resource.CreateReminderResource;
import com.medibox.MedicationAdherenceReminders.resource.ReminderResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateReminderResource;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("api/v1/reminders")
public class ReminderController {
  private final ReminderService reminderService;
  private final ReminderMapper mapper;

  @PostMapping
  public ReminderResource save(@RequestBody CreateReminderResource resource) {
    return mapper.toResource( reminderService.save( mapper.toModel(resource) ) );
  }

  @GetMapping
  public List<Reminder> getAll() {
    return reminderService.getAll();
  }

  @GetMapping("{id}")
  public ReminderResource getById(@PathVariable Long id) {
    return this.mapper.toResource(reminderService.getById(id).get());
  }

  @PutMapping("{id}")
  public ResponseEntity<ReminderResource> update(@PathVariable Long id, @RequestBody UpdateReminderResource resource) {
    if(id.equals(resource.getId())) {
      ReminderResource reminderResource = mapper.toResource(reminderService.update(mapper.toModel(resource)));
      return new ResponseEntity<>(reminderResource, HttpStatus.OK);
    } else {
      return ResponseEntity.badRequest().build();
    }
  }

  @DeleteMapping("{id}")
  public ResponseEntity<ReminderResource> delete(@PathVariable Long id) {
    if (reminderService.deleteById(id)) {
      return ResponseEntity.ok().build();
    } else {
      return ResponseEntity.notFound().build();
    }
  }
}