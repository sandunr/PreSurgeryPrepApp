using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using presurgeryapp.Models;


namespace presurgeryapp.Controllers
{
    [Produces("application/json")]
    [Route("api/DisplayPatients")]
    public class DisplayPatientsController : Controller
    {
        protected ApplicationDbContext context;

        public DisplayPatientsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet()]
        public IEnumerable<ClientApp.Models.Patient> Get()
        {
            var result = from r in context.Patients select r;
            return result;
        }
    }
}