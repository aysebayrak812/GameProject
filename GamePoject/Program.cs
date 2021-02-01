using System;

namespace GamePoject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1,
                BirthYear = 1985, 
                FirstName= "ayşe",
                LastName = "bayrak",
                IdentityNumber=12345
            });
        }
    }
}
