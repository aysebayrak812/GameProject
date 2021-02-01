using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("kayıt oldu");
            }
            else
            {
                Console.WriteLine("doğrulama basarısız");
            }
        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt  silndi");
        }

        public override bool Equals(object obj)
        {
            return obj is GamerManager manager &&
                   EqualityComparer<IUserValidationService>.Default.Equals(_userValidationService, manager._userValidationService);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_userValidationService);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
