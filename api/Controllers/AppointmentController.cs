using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using health_record_app.Models;

namespace health_record_app.Controllers {
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentController : ControllerBase {
        private readonly HealthRecordAppContext db;
        public AppointmentController(HealthRecordAppContext db) {
            this.db = db;
            if (this.db.Appointments.Count() == 0){
                this.db.Appointments.Add(new Appointment(){
                    id = 1,
                    appointment_date = DateTime.Now,
                    reason = "Patient back pain!",
                    doctor = this.db.Doctors.Find(1),
                    patient = this.db.Patient.Find(1)
                });
                this.db.Appointments.Add(new Appointment(){
                    id = 2,
                    appointment_date = DateTime.Now,
                    reason = "Patient's Ear Hurts!",
                    doctor = this.db.Doctors.Find(2),
                    patient = this.db.Patient.Find(3)
                });
                this.db.Appointments.Add(new Appointment(){
                    id = 3,
                    appointment_date = DateTime.Now,
                    reason = "Patient's Left Eye Swollen Shut!",
                    doctor = this.db.Doctors.Find(1),
                    patient = this.db.Patient.Find(3)
                });
                this.db.Appointments.Add(new Appointment(){
                    id = 4,
                    appointment_date = DateTime.Now,
                    reason = "Patient Internal Bleeding!",
                    doctor = this.db.Doctors.Find(2),
                    patient = this.db.Patient.Find(1)
                });
            }
            this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(db.Appointments);
        }
        [HttpGet("{id}")]
        public IActionResult GetAppointment(int id){
            var appt = db.Appointments.FirstOrDefault(a => a.id == id);
            if (appt == null){
                return NotFound();
            }
            return Ok(appt);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Appointment appt){
            if(appt == null){
                return BadRequest();
            }
            db.Appointments.Add(appt);
            db.SaveChanges();

            return CreatedAtRoute("GetAppiontment", new Appointment{ id = appt.id}, appt);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Appointment appt)
        {
            if (appt == null || appt.id != id)
            {
                return BadRequest();
            }
            var apptToUpdate = db.Appointments.FirstOrDefault(b => b.id == id);
            if (apptToUpdate == null)
            {
                return NotFound();
            }
            apptToUpdate.reason = appt.reason;
            apptToUpdate.appointment_date = appt.appointment_date;
            db.Appointments.Update(apptToUpdate);
            db.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var appt = db.Appointments.FirstOrDefault(b => b.id == id);
            if (appt == null)
            {
                return NotFound();
            }
            db.Appointments.Remove(appt);
            db.SaveChanges();

            return NoContent();
        }
    }
}