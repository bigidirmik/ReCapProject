using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); // byte olarak istediği için string yani düz password yazamayız
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) // bunu kullanarak karşılaştıracağını söyledik.
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); // byte array oluşmuştur, for ile döneriz.
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i]) // computedHash önceki metotda out ile referans verdiğimiz ve şimdi çağırdığımız passwordHash ile eşit değilse
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
