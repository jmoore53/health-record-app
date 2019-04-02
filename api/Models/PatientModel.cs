using System;

namespace health_record_app.Models {
    public class Patient {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public char middle_initial { get; set; }
        public DateTime date_of_birth { get; set; }
        public string social_security_number { get; set; }

    }
}