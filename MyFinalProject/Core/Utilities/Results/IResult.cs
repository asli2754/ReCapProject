using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get;  } // yapmaya çalıştığım ekleme işi başarılı mı diye bakacak.
        string Message { get;  } // ekleme başarılımı başarısız mı kullanıcıya bilgi verecek olan mesaj.

    }
}
