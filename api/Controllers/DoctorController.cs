using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using health_record_app.Models;

namespace health_record_app.Controllers {
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase {
            private readonly HealthRecordAppContext db;
public DoctorController(HealthRecordAppContext db) {
            this.db = db;
            if (this.db.Doctors.Count() == 0){
                this.db.Doctors.Add(new Doctor(){
                    id = 1,
                    first_name = "Jeff",
                    last_name = "Smith",
                    social_security_number = "234-22-3432",
                    specialty = "Anesthesiology"
                });
                this.db.Doctors.Add(new Doctor(){
                    id = 2,
                    first_name = "Eric",
                    last_name = "Harlem",
                    social_security_number = "167-93-8279",
                    specialty = "Oncology"
                });
                this.db.Doctors.Add(new Doctor(){
                    id = 3,
                    first_name = "Alex",
                    last_name = "Weiss",
                    social_security_number = "627-93-9367",
                    specialty = "Cytopathology"
                });
                this.db.Doctors.Add(new Doctor(){
                    id = 4,
                    first_name = "Lisa",
                    last_name = "Kodish",
                    social_security_number = "536-74-3457",
                    specialty = "Pediatric Pathology"
                });
            }
            this.db.SaveChanges();
}

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(db.Doctors);
        }


        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id){
            var doc = db.Doctors.FirstOrDefault(a => a.id == id);
            if (doc == null){
                return NotFound();
            }
            return Ok(doc);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Doctor doc){
            if(doc == null){
                return BadRequest();
            }
            db.Doctors.Add(doc);
            db.SaveChanges();

            return CreatedAtRoute("GetDoctor", new Doctor{ id = doc.id}, doc);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Doctor doc)
        {
            if (doc == null || doc.id != id)
            {
                return BadRequest();
            }
            var docToUpdate = db.Doctors.FirstOrDefault(b => b.id == id);
            if (docToUpdate == null)
            {
                return NotFound();
            }
            docToUpdate.first_name = doc.first_name;
            docToUpdate.last_name = doc.last_name;
            docToUpdate.social_security_number = doc.social_security_number;
            docToUpdate.specialty = doc.specialty;
            db.Doctors.Update(docToUpdate);
            db.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var doc = db.Doctors.FirstOrDefault(b => b.id == id);
            if (doc == null)
            {
                return NotFound();
            }
            db.Doctors.Remove(doc);
            db.SaveChanges();

            return NoContent();
        }
    }
}


            
