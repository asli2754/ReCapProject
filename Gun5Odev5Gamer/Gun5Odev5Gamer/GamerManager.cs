using System;
using System.Collections.Generic;
using System.Text;


//micro service. 
namespace Gun5Odev5Gamer
{
   

    class GamerManager : IGamerService
    {
        //bir sınıf içerisinde başka sınıf kullanacaksan new yapma!, onun yerine aşağıdakini yap.
        //yani aşağıdaki gibi constructer yap;
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
