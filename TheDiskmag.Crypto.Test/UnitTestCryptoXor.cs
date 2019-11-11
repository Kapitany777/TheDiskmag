using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheDiskmag.Crypto;

namespace TheDiskmag.Crypto.Test
{
    [TestClass]
    public class UnitTestCryptoXor
    {
        [TestMethod]
        public void TestConstructorKeySetting()
        {
            CryptoXor crypto = new CryptoXor(128);

            Assert.AreEqual(128, crypto.Key);
        }
        
        [TestMethod]
        public void DecryptEmptyData()
        {
            byte[] data = new byte[0];
            CryptoXor crypto = new CryptoXor(128);
            byte[] decryptedData = crypto.Decrypt(data);

            Assert.AreEqual(0, decryptedData.Length);
        }

        [TestMethod]
        public void EncryptEmptyData()
        {
            byte[] data = new byte[0];
            CryptoXor crypto = new CryptoXor(128);
            byte[] encryptedData = crypto.Encrypt(data);

            Assert.AreEqual(0, encryptedData.Length);
        }

        [TestMethod]
        public void TestDecryption()
        {
            int key = 128;
            byte[] data = new byte[] { 0, 100, 128, 255 };
            CryptoXor crypto = new CryptoXor(128);
            byte[] decryptedData = crypto.Encrypt(data);

            Assert.AreEqual(data[0] ^ key, decryptedData[0]);
            Assert.AreEqual(data[1] ^ key, decryptedData[1]);
            Assert.AreEqual(data[2] ^ key, decryptedData[2]);
            Assert.AreEqual(data[3] ^ key, decryptedData[3]);
        }

        [TestMethod]
        public void TestEncryption()
        {
            int key = 128;
            byte[] data = new byte[] { 0, 100, 128, 255 };
            CryptoXor crypto = new CryptoXor(128);
            byte[] encryptedData = crypto.Encrypt(data);

            Assert.AreEqual(data[0] ^ key, encryptedData[0]);
            Assert.AreEqual(data[1] ^ key, encryptedData[1]);
            Assert.AreEqual(data[2] ^ key, encryptedData[2]);
            Assert.AreEqual(data[3] ^ key, encryptedData[3]);
        }
    }
}
