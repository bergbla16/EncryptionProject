using System;

namespace EncryptionProject
{

    public abstract class TextDecryption
    {
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
    }

}
