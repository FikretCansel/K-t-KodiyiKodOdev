using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness
{
    public class UserValidation
    {
        public bool Register(string username, string password)
        {


            if(password.Length < 6)
            {
                return false;
            }
            return true;

        }

        public bool Login(string username, string password)
        {


            return true;

        }
    }
}
