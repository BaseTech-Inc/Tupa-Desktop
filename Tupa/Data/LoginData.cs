using System;

namespace Tupa.Data
{
    public class LoginData
    {   
            public string uid { get; set; }

            public string access_token { get; set; }

            public string token_type { get; set; }

            public DateTime expiration { get; set; }       
    }
}
