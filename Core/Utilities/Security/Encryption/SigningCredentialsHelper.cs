using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper //Giriş bilgileri yardımcısı // securitykeyhelper'dan gelen byte'a çevrilmiş securitykey'i algoritma ile üretiyoruz
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);//web.api'nin de hash sistemine ihtiyacı var, hangi anahtar, hangi algoritma kullanılacak diyoruz
        }
    }
}
