using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using presurgeryapp.ClientApp.Models;
using presurgeryapp.Models;
using Hangfire;
using System.Collections.Generic;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace presurgeryapp.Controllers
{

    [Produces("application/json")]
    [Route("api/Schedule")]
    public class ScheduleController : Controller
    {
        protected ApplicationDbContext context;
        private List<ClientApp.Models.Patient> patients;

        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "";
        const string authToken = "";

        public ScheduleController(ApplicationDbContext context)
        {
            this.context = context;
            patients = new List<ClientApp.Models.Patient>();
            TwilioClient.Init(accountSid, authToken);
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return null;
        }

        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            if (patient != null)
            {
                patient.Id = new Guid();
                context.Patients.Add(patient);

                var colorectal = new Colorectal();
                var abdominalHysterectomies = new AbdominalHysterectomies();
                var cardiacAndSternal = new CardiacAndSternal();
                string body = "";

                switch(patient.SurgeryType)
                {
                    case "Colorectal":
                        colorectal.Text1 += patient.SurgeryDate;
                        colorectal.PatientId = patient.Id;

                        body = colorectal.Text1;
                        colorectal.Txt1Freq = 0;
                        RunInBackground(patient.Phone, body);

                        colorectal.Txt2Freq = 5;
                        body = cardiacAndSternal.Text2;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        colorectal.Txt3Freq = 10;
                        body = cardiacAndSternal.Text3;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        colorectal.Txt4Freq = 15;
                        body = cardiacAndSternal.Text4;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        colorectal.Txt5Freq = 20;
                        body = cardiacAndSternal.Text5;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        colorectal.Txt6Freq = 25;
                        body = cardiacAndSternal.Text6;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        colorectal.Txt7Freq = 30;
                        body = cardiacAndSternal.Text7;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        context.Colorectal.Add(colorectal);
                        break;
                    case "Cardiac & Sternal Surgery":
                        cardiacAndSternal.Text1 += patient.SurgeryDate;
                        cardiacAndSternal.PatientId = patient.Id;

                        body = cardiacAndSternal.Text1;
                        cardiacAndSternal.Txt1Freq = 0;
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt2Freq = 5;
                        body = cardiacAndSternal.Text2;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt3Freq = 10;
                        body = cardiacAndSternal.Text3;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt4Freq = 15;
                        body = cardiacAndSternal.Text4;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt5Freq = 20;
                        body = cardiacAndSternal.Text5;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt6Freq = 25;
                        body = cardiacAndSternal.Text6;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt7Freq = 30;
                        body = cardiacAndSternal.Text7;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt8Freq = 35;
                        body = cardiacAndSternal.Text8;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        cardiacAndSternal.Txt9Freq = 40;
                        System.Threading.Thread.Sleep(10);
                        body = cardiacAndSternal.Text9;
                        RunInBackground(patient.Phone, body);

                        context.CardiacAndSternal.Add(cardiacAndSternal);
                        break;
                    default:
                        abdominalHysterectomies.Text1 += patient.SurgeryDate;
                        abdominalHysterectomies.PatientId = patient.Id;

                        abdominalHysterectomies.Txt1Freq = 0;
                        body = abdominalHysterectomies.Text1;
                        RunInBackground(patient.Phone, body);

                        abdominalHysterectomies.Txt1Freq = 5;
                        body = abdominalHysterectomies.Text2;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        abdominalHysterectomies.Txt2Freq = 10;
                        body = abdominalHysterectomies.Text3;
                        System.Threading.Thread.Sleep(10);
                        RunInBackground(patient.Phone, body);

                        context.AbdominalHysterectomies.Add(abdominalHysterectomies);
                        break;
                }
                context.SaveChanges();
            }
        }

        private void RunInBackground(string phone, string body)
        {
            //var to = new PhoneNumber("+1" + phone);
            //var message = MessageResource.Create(
            //    to,
            //    from: new PhoneNumber("+12062073180"),
            //    body: body);
        }
    }
}