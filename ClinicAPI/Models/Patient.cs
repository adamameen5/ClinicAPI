using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Models
{
    public class Patient
    {
        public int patientId { get; set; }
        public string patientName { get; set; }
        public string patientAddress { get; set; }
        public string patientEmail { get; set; }
    }
}
