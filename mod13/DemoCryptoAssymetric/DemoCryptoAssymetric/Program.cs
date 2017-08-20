using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DemoCryptoAssymetric
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuTexto = "Testando criptografia";

            var rSACrypto = new RSACryptoServiceProvider();

            //Gerar key
            string privateKey = rSACrypto.ToXmlString(true);
            string publicKey = rSACrypto.ToXmlString(false);

            //Criptografia
            var dataToEncrypt = Encoding.UTF8.GetBytes(meuTexto);
            rSACrypto.FromXmlString(publicKey);
            var encrypt = rSACrypto.Encrypt(dataToEncrypt, false);
            Console.WriteLine(Encoding.UTF8.GetString(encrypt));


            //Descriptografar
            var rSAEnCrypto = new RSACryptoServiceProvider();
            rSAEnCrypto.FromXmlString(privateKey);
            var decriptArray = rSAEnCrypto.Decrypt(encrypt, false);
            var textoOriginal = Encoding.UTF8.GetString(decriptArray);
            Console.WriteLine(textoOriginal);



            Console.ReadLine();

        }
    }
}
