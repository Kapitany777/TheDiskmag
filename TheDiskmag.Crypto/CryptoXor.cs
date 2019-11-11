using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDiskmag.Crypto
{
    public class CryptoXor : ICrypto
    {
        public byte Key { get; private set; }

        public CryptoXor(byte key)
        {
            this.Key = key;
        }

        public byte[] Decrypt(byte[] data)
        {
            byte[] decryptedData = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                decryptedData[i] = (byte)(data[i] ^ this.Key);
            }

            return decryptedData;
        }

        public byte[] Encrypt(byte[] data)
        {
            byte[] encryptedData = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                encryptedData[i] = (byte)(data[i] ^ this.Key);
            }

            return encryptedData;
        }
    }

}
