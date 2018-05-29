using System.ComponentModel.DataAnnotations;
using System;

namespace presurgeryapp.ClientApp.Models
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public string Phone { get; set; }
        
        public string SurgeryDate { get; set; }

        public bool TextSent { get; set; }
        
        public string SurgeryType { get; set; }

        public string PatientResponse { get; set; }
    }
}
