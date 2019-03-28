using System;
using System.Security.Cryptography;
using System.Text;

namespace RSAEncryption
{
    public static class RSAEncrypter
    {
        /// <summary>
        /// Metodo de encriptación del texto
        /// </summary>
        /// <param name="text">Texto a encriptar</param>
        /// <param name="xmlPublic">Clave púplica</param>
        /// <returns></returns>
        public static byte[] Encrypt(string text, string xmlPublic)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPublic);
            byte[] encryptedData = RSA.Encrypt(Encoding.UTF8.GetBytes(text), false);
            return encryptedData;
        }

        /// <summary>
        /// Metodo de desencriptación de texto
        /// </summary>
        /// <param name="encryptedText">Texto encriptado</param>
        /// <param name="xmlPrivate">Clave privada</param>
        /// <returns></returns>
        public static byte[] Decrypt(string encryptedText, string xmlPrivate)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPrivate);
            byte[] decryptData = RSA.Decrypt(Convert.FromBase64String(encryptedText), false);
            return decryptData;
        }
    }
}
