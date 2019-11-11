using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiskmag.Crypto
{
    public interface ICrypto
    {
        byte[] Encrypt(byte[] data);
        byte[] Decrypt(byte[] data);
    }
}
