package com.medibox.MedicationAdherenceReminders.frequency.api;

import com.medibox.MedicationAdherenceReminders.frequency.domain.model.entity.Frequency;
import com.medibox.MedicationAdherenceReminders.frequency.domain.service.FrequencyService;
import com.medibox.MedicationAdherenceReminders.frequency.mapping.FrequencyMapper;
import com.medibox.MedicationAdherenceReminders.frequency.resource.CreateFrequencyResource;
import com.medibox.MedicationAdherenceReminders.frequency.resource.FrequencyResource;
import com.medibox.MedicationAdherenceReminders.frequency.resource.UpdateFrequencyResource;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("api/v1/frequencies")
@AllArgsConstructor
public class FrequencyController {
  private final FrequencyService frequencyService;
  private final FrequencyMapper mapper;

  @PostMapping
  public FrequencyResource save(@RequestBody CreateFrequencyResource resource) {
    return mapper.toResource( frequencyService.save( mapper.toModel(resource) ) );
  }

  @GetMapping
  public List<Frequency> getAll() {
    return frequencyService.getAll();
  }

  /*@GetMapping("{id}")
  public FrequencyResource getById(@PathVariable Long id) {
    return this.mapper.toResource(frequencyService.getById(id).get());
  }*/

  @PutMapping("{id}")
  public ResponseEntity<FrequencyResource> update(@PathVariable Long id, @RequestBody UpdateFrequencyResource resource) {
    if(id.equals(resource.getId())) {
      FrequencyResource frequencyResource = mapper.toResource(frequencyService.update(mapper.toModel(resource)));
      return new ResponseEntity<>(frequencyResource, HttpStatus.OK);
    } else {
      return ResponseEntity.badRequest().build();
    }
  }

  /*@DeleteMapping("{id}")
  public ResponseEntity<FrequencyResource> delete(@PathVariable Long id) {
    if (frequencyService.deleteById(id)) {
      return ResponseEntity.ok().build();
    } else {
      return ResponseEntity.notFound().build();
    }
  }*/
}
