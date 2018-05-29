using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace presurgeryapp.ClientApp.Models
{
    [Table("AbdominalHysterectomies")]
    public class AbdominalHysterectomies : ISurgery
    {

        public AbdominalHysterectomies()
        {
            Text1 = "You have been scheduled for surgery ";
            Text2 = "Tomorrow is your surgery.  Remember to take you nighttime shower with the soap provided by the clinic (CHG) and DO NOT eat or drink anything after midnight (including gum or hard candies)";
            Text3 = "Today is the day! Make sure you take our morning shower with the soap provided by the clinic (CHG) and bring your ID and insurance card with you";
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Patient")]
        public Guid PatientId { get; set; }

        public string Text1 { get; set; }

        public int Txt1Freq { get; set; }

        public string Text2 { get; set; }

        public int Txt2Freq { get; set; }

        public string Text3 { get; set; }

        public int Txt3Freq { get; set; }
    }
}
