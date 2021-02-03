using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5Gamer
{
    class UserValidationManager : IUserValidationService //bunun yerine kimlik doğrulama sistemini de entegreedebilirdik.

    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1994 && gamer.FirstName == "Asli" 
                && gamer.LastName == "Efe" && gamer.IdentityNumber ==1234)

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
