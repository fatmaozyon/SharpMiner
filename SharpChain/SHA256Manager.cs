using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SharpChain
{
    internal class SHA256Manager
    {
        public string GetHash(string data)
        {
            var sha256 = new SHA256Manager();
            var hashBuilder = new StringBuilder();

            var dataBytes = System.Text.Encoding.Unicode.GetBytes(data);
            var hash = sha256.ComputeHash(dataBytes);

            foreach(var b in hash)
            {
                hashBuilder.Append($"{b:x2}");
            }

            return hashBuilder.ToString();

        }

        
    }
}
