using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace presurgeryapp.ClientApp.Models
{
    [Table("Colorectal")]
    public class Colorectal : ISurgery
    {
        public Colorectal()
        {
            Text1 = "You have been scheduled for surgery on ";
            Text2 = "5 days until surgery- Drink your protein shake";
            Text3 = "4 days until surgery- Drink your protein shake";
            Text4 = "3 days until surgery- Drink your protein shake";
            Text5 = "2 days until surgery- Drink your protein shake";
            Text6 = "Tomorrow is your surgery.  Drink your protein shake, " +
                                                "preform your bowel prep (see clinic instructions), take our antibiotic, take you nighttime shower with the " +
                                                "soap provided by the clinic (CHG), and DO NOT eat or drink anything after midnight (including gum or hard candies)";
            Text7 = "Today is the day! Make sure you take our morning shower with the soap " +
                                                "provided by the clinic (CHG) and bring your ID and insurance card with you";
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

        public string Text4 { get; set; }

        public int Txt4Freq { get; set; }

        public string Text5 { get; set; }

        public int Txt5Freq { get; set; }

        public string Text6 { get; set; }

        public int Txt6Freq { get; set; }

        public string Text7 { get; set; }

        public int Txt7Freq { get; set; }
    }
}
