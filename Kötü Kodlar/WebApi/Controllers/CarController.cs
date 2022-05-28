using Businness;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {

        [HttpPost("Add")]
        public bool Add(string name, string description)
        {
            CarValidation carValidation = new CarValidation();
            if (carValidation.ALLGET())
            {
                return false;
            }


            using (dBCOntext context = new dBCOntext())
            {
                return context.Set<Car>().SingleOrDefault();
            }

        }


        [HttpPost("ALLGET")]
        public bool ALLGET()
        {
            using (dBCOntext context = new dBCOntext())
            {
                var addedEntity = context.Entry(new User { userID = userId, Password = password, userNaME = username });
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
