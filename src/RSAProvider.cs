using System.Security.Cryptography;
using System.Text;

namespace RSAEncryption
{
    public class RSAProvider
    {
        public RSACryptoServiceProvider RSAService { get; set; }

        public RSAProvider()
        {
            RSAService = new RSACryptoServiceProvider();
        }

        public byte[] CreatePublicKey()
        {
            string xmlPublicKey = RSAService.ToXmlString(false);
            return Encoding.ASCII.GetBytes(xmlPublicKey);
        }

        public byte[] CreatePrivateKey()
        {
            string xmlPrivateKey = RSAService.ToXmlString(true);
            return Encoding.ASCII.GetBytes(xmlPrivateKey);
        }
    }
}
