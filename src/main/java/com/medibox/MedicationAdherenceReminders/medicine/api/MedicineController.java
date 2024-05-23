package com.medibox.MedicationAdherenceReminders.medicine.api;

import com.medibox.MedicationAdherenceReminders.medicine.domain.model.entity.Medicine;
import com.medibox.MedicationAdherenceReminders.medicine.domain.service.MedicineService;
import com.medibox.MedicationAdherenceReminders.medicine.mapping.MedicineMapper;
import com.medibox.MedicationAdherenceReminders.medicine.resource.CreateMedicineResource;
import com.medibox.MedicationAdherenceReminders.medicine.resource.MedicineResource;
import com.medibox.MedicationAdherenceReminders.medicine.resource.UpdateMedicineResource;
import lombok.AllArgsConstructor;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("medicines")
public class MedicineController {
  private final MedicineService medicineService;
  private final MedicineMapper mapper;

  @PostMapping
  public MedicineResource save(@RequestBody CreateMedicineResource resource) {
    return mapper.toResource( medicineService.save( mapper.toModel(resource) ) );
  }

  @GetMapping
  public List<Medicine> getAll() {
    return medicineService.getAll();
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
