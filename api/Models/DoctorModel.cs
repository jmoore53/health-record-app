using System;

namespace health_record_app.Models {
    public class Doctor {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string social_security_number { get; set; }
        public string specialty { get; set; }
    }
}