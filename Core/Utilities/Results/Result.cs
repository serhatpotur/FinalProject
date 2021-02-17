using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message) : this(success) // tek parametreli olanı da çalıştır demek
        {
            Message = message; // kullanıcıya mesaj da göstersin

        }

        public Result(bool success)
        {

            Success = success; //sadece başarılı/ başarısız olayını kontrol etsin
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
