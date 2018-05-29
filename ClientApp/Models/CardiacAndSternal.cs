using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace presurgeryapp.ClientApp.Models
{
    [Table("CardiacAndSternal")]
    public class CardiacAndSternal : ISurgery
    {

        public CardiacAndSternal()
        {
            Text1 = "You have been scheduled for surgery on ";
            Text2 = "7 days until surgery- Apply bacitracin ointment to the inside of your nose (nostrils/ nares)";
            Text3 = "6 days until surgery- Apply bacitracin ointment to the inside of your nose (nostrils/ nares)";
            Text4 = "5 days until surgery- Apply bacitracin ointment to the inside of your nose (nostrils/ nares)";
            Text5 = "4 days until surgery- Apply bacitracin ointment to the inside of your nose (nostrils/ nares)";
            Text6 = "3 days until surgery- Apply bacitracin ointment to the inside of your nose (nostrils/ nares)";
            Text7 = "2 days until surgery- Apply bacitracin ointment to the inside of your nose (nostrils/ nares)";
            Text8 = "Tomorrow is your surgery. Remember to apply bacitracin ointment to the inside of your nose (nostrils/ nares), take you nighttime shower with the soap provided by the clinic (CHG), change your bed linens and DO NOT eat or drink anything after midnight (including gum or hard candies)";
            Text9 = "Today is the day! Make sure you take our morning shower with the soap provided by the clinic (CHG), apply bacitracin ointment to the inside of your nose (nostrils/ nares) and bring your ID and insurance card with you";
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

        public string Text8 { get; set; }

        public int Txt8Freq { get; set; }

        public string Text9 { get; set; }

        public int Txt9Freq { get; set; }
    }
}
