using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class SecureData
    {
        public static string EncryptData(string SimpleString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = Encoding.UTF8.GetBytes(SimpleString);

            return Encoding.UTF8.GetString(md5.ComputeHash(passwordHash));
        }
    }
}
