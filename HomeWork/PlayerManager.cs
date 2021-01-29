using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class PlayerManager : lGamerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(PlayerInfo gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("kayıt oldu");
            }
            

            else
            {
                Console.WriteLine("kayıt başarısız");
            }
        }

        public void Delete(PlayerInfo gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(PlayerInfo gamer)
        {
            throw new NotImplementedException();
        }
    }
}
