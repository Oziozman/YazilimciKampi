using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjects
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1993 && gamer.FirstName =="OGUZHAN" &&gamer.LastName =="BILGIC"&&gamer.IdentityNumber==12345)
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
