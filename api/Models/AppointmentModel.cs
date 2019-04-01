using System;

namespace health_record_app.Models {
    public class Appointment {
        public int id { get; set; }
        public DateTime appointment_date { get; set; }
        public string reason { get; set; }

        public int doctor_id { get; set; }
        public int patient_id { get; set; }
    }
}