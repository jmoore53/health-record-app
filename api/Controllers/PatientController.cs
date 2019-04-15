using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using health_record_app.Models;

namespace health_record_app.Controllers {
    [Route("api/patients")]
    [ApiController]
    public class PatientController : ControllerBase {
            private readonly HealthRecordAppContext db;

            public PatientController(HealthRecordAppContext db) {
            this.db = db;
            if (this.db.Patient.Count() == 0){
                this.db.Patient.Add(new Patient(){
                    id = 1,
                    first_name = "John",
                    last_name = "Smith",
                    middle_initial = 'M',
                    date_of_birth = DateTime.Now,
                    social_security_number = "877-91-9101"
                });
                this.db.Patient.Add(new Patient(){
                    id = 2,
                    first_name = "Eric",
                    last_name = "Smith",
                    middle_initial = 'L',
                    date_of_birth = DateTime.Now,
                    social_security_number = "845-91-9101"
                });
                this.db.Patient.Add(new Patient(){
                    id = 3,
                    first_name = "Alex",
                    last_name = "Richards",
                    middle_initial = 'K',
                    date_of_birth = DateTime.Now,
                    social_security_number = "847-91-9111"
                });
                this.db.Patient.Add(new Patient(){
                    id = 4,
                    first_name = "Holly",
                    last_name = "Klander",
                    middle_initial = 'O',
                    date_of_birth = DateTime.Now,
                    social_security_number = "194-145-194"
                });
            }
            this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(db.Appointments);
        }
        [HttpGet("{id}")]
        public IActionResult GetPatient(int id){
            var pats = db.Patient.FirstOrDefault(a => a.id == id);
            if (pats == null){
                return NotFound();
            }
            return Ok(pats);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Patient pats){
            if(pats == null){
                return BadRequest();
            }
            db.Patient.Add(pats);
            db.SaveChanges();

            return CreatedAtRoute("GetPatient", new Patient{ id = pats.id}, pats);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Patient pats)
        {
            if (pats == null || pats.id != id)
            {
                return BadRequest();
            }
            var patsToUpdate = db.Patient.FirstOrDefault(b => b.id == id);
            if (patsToUpdate == null)
            {
                return NotFound();
            }
            patsToUpdate.first_name = pats.first_name;
            patsToUpdate.last_name = pats.last_name;
            patsToUpdate.middle_initial = pats.middle_initial;
            patsToUpdate.date_of_birth = pats.date_of_birth;
            patsToUpdate.social_security_number = pats.social_security_number;
            db.Patient.Update(patsToUpdate);
            db.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var pats = db.Patient.FirstOrDefault(b => b.id == id);
            if (pats == null)
            {
                return NotFound();
            }
            db.Patient.Remove(pats);
            db.SaveChanges();

            return NoContent();
        }
    }

}