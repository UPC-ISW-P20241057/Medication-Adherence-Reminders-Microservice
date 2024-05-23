package com.medibox.MedicationAdherenceReminders.interval.api;

import com.medibox.MedicationAdherenceReminders.interval.domain.model.entity.Interval;
import com.medibox.MedicationAdherenceReminders.interval.domain.service.IntervalService;
import com.medibox.MedicationAdherenceReminders.interval.mapping.IntervalMapper;
import com.medibox.MedicationAdherenceReminders.interval.resource.CreateIntervalResource;
import com.medibox.MedicationAdherenceReminders.interval.resource.IntervalResource;
import com.medibox.MedicationAdherenceReminders.interval.resource.UpdateIntervalResource;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("intervals")
@AllArgsConstructor
public class IntervalController {
  private final IntervalService intervalService;
  private final IntervalMapper mapper;

  @PostMapping
  public IntervalResource save(@RequestBody CreateIntervalResource resource) {
    return mapper.toResource( intervalService.save( mapper.toModel(resource) ) );
  }

  @GetMapping
  public List<Interval> getAll() {
    return intervalService.getAll();
  }

  /*@GetMapping("{id}")
  public IntervalResource getById(@PathVariable Long id) {
    return this.mapper.toResource(intervalService.getById(id).get());
  }*/

  @PutMapping("{id}")
  public ResponseEntity<IntervalResource> update(@PathVariable Long id, @RequestBody UpdateIntervalResource resource) {
    if(id.equals(resource.getId())) {
      IntervalResource intervalResource = mapper.toResource(intervalService.update(mapper.toModel(resource)));
      return new ResponseEntity<>(intervalResource, HttpStatus.OK);
    } else {
      return ResponseEntity.badRequest().build();
    }
  }

  /*@DeleteMapping("{id}")
  public ResponseEntity<IntervalResource> delete(@PathVariable Long id) {
    if (intervalService.deleteById(id)) {
      return ResponseEntity.ok().build();
    } else {
      return ResponseEntity.notFound().build();
    }
  }*/
}
