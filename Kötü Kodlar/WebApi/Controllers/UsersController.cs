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
    public class UsersController : Controller
    {

        [HttpPost("login")]
        public bool LOGIN(int userId,string username,string password)
        {

            UserValidation userValidation = new UserValidation();

            if (userValidation.Login(username,password))
            {
                return false;
            }


            using (dBCOntext context = new dBCOntext())
            {
                return context.Set<User>().SingleOrDefault();
            }
            
        }


        [HttpPost("register")]
        public bool REGISTER(int userId, string username, string password)
        {
            UserValidation userValidation = new UserValidation();

            if (userValidation.Register(username, password))
            {
                return false;
            }
            using (dBCOntext context = new dBCOntext())
            {
                var addedEntity = context.Entry(new User {userID=userId,Password=password,userNaME=username });
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            return true;
        }
    }
}
