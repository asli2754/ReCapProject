using System;

namespace Gun5Odev5Gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1,
                BirthYear = 1994,
                FirstName = "Asli",
                IdentityNumber = 1234, 
                LastName = "Efe"
            });
        }
    }
}
