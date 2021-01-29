using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class UserValidationManager : IUserValidationService

    {
        private const string V = "engin";

        public bool Validate(PlayerInfo gamer)
        {
            if (gamer.BirthdayYear == 1965 && gamer.FirstName = "V")
            {
                return true;

                else 
                return false;
            }
        }
    }
}
