package com.medibox.MedicationAdherenceReminders.api;

import com.medibox.MedicationAdherenceReminders.domain.model.entity.Medicine;
import com.medibox.MedicationAdherenceReminders.domain.service.MedicineService;
import com.medibox.MedicationAdherenceReminders.mapping.MedicineMapper;
import com.medibox.MedicationAdherenceReminders.resource.CreateMedicineResource;
import com.medibox.MedicationAdherenceReminders.resource.MedicineResource;
import com.medibox.MedicationAdherenceReminders.resource.UpdateMedicineResource;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("api/v1/medicines")
public class MedicineController {
  private final MedicineService medicineService;
  private final MedicineMapper mapper;

  @PostMapping
  public MedicineResource save(@RequestBody CreateMedicineResource resource) {
    return mapper.toResource( medicineService.save( mapper.toModel(resource) ) );
  }

  @GetMapping
  public List<MedicineResource> getAll() {
    return mapper.toResourceList(medicineService.getAll());
  }

  @GetMapping("{id}")
  public MedicineResource getById(@PathVariable Long id) {
    return this.mapper.toResource(medicineService.getById(id).get());
  }

  @PutMapping("{id}")
  public ResponseEntity<MedicineResource> update(@PathVariable Long id, @RequestBody UpdateMedicineResource resource) {
    if(id.equals(resource.getId())) {
      MedicineResource medicineResource = mapper.toResource(medicineService.update(mapper.toModel(resource)));
      return new ResponseEntity<>(medicineResource, HttpStatus.OK);
    } else {
      return ResponseEntity.badRequest().build();
    }
  }

  @DeleteMapping("{id}")
  public ResponseEntity<MedicineResource> delete(@PathVariable Long id) {
    if (medicineService.deleteById(id)) {
      return ResponseEntity.ok().build();
    } else {
      return ResponseEntity.notFound().build();
    }
  }
}
