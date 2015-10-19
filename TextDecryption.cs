using System;

namespace EncryptionProject
{

    public abstract class TextDecryption
    {
        public const string testString = "testString";
        public TextDecryption(string algorithmName)
        {
            algorithmName = this.algorithmName;

        }

        public string algorithmName;

        public abstract string getInfo(); //Returns description of algorithm
        public abstract string decryptWithForce(string encryptedMessage); //Decrypts method using force
    }

    public class DecryptCaesarCypher : TextDecryption
    {
        public DecryptCaesarCypher(string algorithmName)
        {
            this.algorithmName = algorithmName;
        }
        //Which cypher is being decoded
        public string getInfo()
        {
            return algorithmName;
        }

        //Decrypt specified cypher with force
        public string decryptWithForce(string encryptedMessage)
        {


            byte[] messageInAscii = Encoding.ASCII.GetBytes(testString);

            foreach (byte b in messageInAscii)
            {
                Console.WriteLine(b);
            }
        }

    }

}

