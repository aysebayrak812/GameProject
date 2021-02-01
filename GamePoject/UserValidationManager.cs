using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1985 && gamer.FirstName=="ayşe"
                && gamer.LastName=="bayrak"
                && gamer.IdentityNumber == 1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
