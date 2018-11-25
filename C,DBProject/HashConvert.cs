using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace C_DBProject
{
    class HashConvert
    {
        public string ConvertSha256(string Pwd)
        {
            var Sha256 = new SHA256CryptoServiceProvider();
            byte[] ResultHash = Sha256.ComputeHash(Encoding.Default.GetBytes(Pwd));
            StringBuilder TransPwd = new StringBuilder();

            foreach(var hash in ResultHash)
            {
                TransPwd.AppendFormat("{0:x2}", hash);
            }
            return TransPwd.ToString();
        }
    }
}
