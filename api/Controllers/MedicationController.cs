using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using health_record_app.Models;

namespace health_record_app.Controllers {
    [Route("api/medications")]
    [ApiController]
    public class MedicationController : ControllerBase {
            private readonly HealthRecordAppContext db;

            public MedicationController(HealthRecordAppContext db) {
            this.db = db;
            if (this.db.Medications.Count() == 0){
                this.db.Medications.Add(new Medication(){
                    id = 1,
                    name = "Romycin",
                    dosage = "250mg"
                });
                this.db.Medications.Add(new Medication(){
                    id = 2,
                    name = "Penicillin",
                    dosage = "150mg"
                });
                this.db.Medications.Add(new Medication(){
                    id = 3,
                    name = "Ibuprofen",
                    dosage = "200mg"
                });
                this.db.Medications.Add(new Medication(){
                    id = 4,
                    name = "Zithromax",
                    dosage = "150mg"
                });
            }
            this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(db.Medications);
        }
        [HttpGet("{id}")]
        public IActionResult GetMedication(int id){
            var med = db.Medications.FirstOrDefault(a => a.id == id);
            if (med == null){
                return NotFound();
            }
            return Ok(med);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Medication med){
            if(med == null){
                return BadRequest();
            }
            db.Medications.Add(med);
            db.SaveChanges();

            return CreatedAtRoute("GetMedication", new Medication{ id = med.id}, med);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Medication med)
        {
            if (med == null || med.id != id)
            {
                return BadRequest();
            }
            var medToUpdate = db.Medications.FirstOrDefault(b => b.id == id);
            if (medToUpdate == null)
            {
                return NotFound();
            }
            medToUpdate.name = med.name;
            medToUpdate.dosage = med.dosage;
            db.Medications.Update(medToUpdate);
            db.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var med = db.Medications.FirstOrDefault(b => b.id == id);
            if (med == null)
            {
                return NotFound();
            }
            db.Medications.Remove(med);
            db.SaveChanges();

            return NoContent();
        }
    }
}