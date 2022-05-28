using System;

namespace Businness
{
    public class CarValidation
    {
        public bool Add(string Name, string Description)
        {

            if(Name == null && Description == null)
            {
                return false;
            }
            return true;

        }

        public bool ALLGET()
        {


            return true;

        }
    }
}
