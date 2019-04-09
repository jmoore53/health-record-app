using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using health_record_app.Models;

namespace health_record_app.Controllers {
    [Route("api/illnesses")]
    [ApiController]
    public class IllnessController : ControllerBase {
            private readonly HealthRecordAppContext db;

            public IllnessController(HealthRecordAppContext db) {
                this.db = db;
                if (this.db.Illnesses.Count() == 0){
                this.db.Illnesses.Add(new Illness(){
                    id = 1,
                    name = "Conjunctivitis"
                });
                this.db.Illnesses.Add(new Illness(){
                    id = 2,
                    name = "Appendicitis"
                });
                this.db.Illnesses.Add(new Illness(){
                    id = 3,
                    name = "Bronchitis"
                });
                this.db.Illnesses.Add(new Illness(){
                    id = 4,
                    name = "Pneumonia"
                });
            }
            this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(db.Illnesses);
        }
        [HttpGet("{id}")]
        public IActionResult GetIllness(int id){
            var ill = db.Illnesses.FirstOrDefault(a => a.id == id);
            if (ill == null){
                return NotFound();
            }
            return Ok(ill);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Illness ill){
            if(ill == null){
                return BadRequest();
            }
            db.Illnesses.Add(ill);
            db.SaveChanges();

            return CreatedAtRoute("GetIllness", new Illness{ id = ill.id}, ill);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Illness ill)
        {
            if (ill == null || ill.id != id)
            {
                return BadRequest();
            }
            var illToUpdate = db.Illnesses.FirstOrDefault(b => b.id == id);
            if (illToUpdate == null)
            {
                return NotFound();
            }
            illToUpdate.id = ill.id;
            illToUpdate.name = ill.name;
            db.Illnesses.Update(illToUpdate);
            db.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var ill = db.Illnesses.FirstOrDefault(b => b.id == id);
            if (ill == null)
            {
                return NotFound();
            }
            db.Illnesses.Remove(ill);
            db.SaveChanges();

            return NoContent();
        }
    }
}