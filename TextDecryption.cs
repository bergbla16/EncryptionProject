using System;

namespace EncryptionProject
{

    public abstract class TextDecryption
    { 
        public TextDecryption(string algorithmName)
        public const int LOWER_ASCII_BOUND = 97;
        public const int UPPER_ASCII_BOUND = 122;
        public const int[] ASCII_EXCEPTIONS = new int[1] {32}; 
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


            byte[] originalMessageInAscii = Encoding.ASCII.GetBytes(encryptedMessage);
            byte[] changedMessage = new Array(originalMessageInAscii.GetLength());

            int length = originalMessageInAscii.GetLength();

            //Checks each letter of the alphabet (lower case only)
            for(int i = 0; i < 26; i++)
            {
                //Shifts ascii value in originalMessage by i to check
                for (int j = 0; j < length; j++)
                {
                    changedMessage[j] = originalMessageInAscii[j] + i;

                    if
                    Console.WriteLine(Encoding.ASCII.GetString(changedMessage, 0, length));
                }
            }
            
            /*
            foreach (byte b in messageInAscii)
            {
                Console.WriteLine(b);
            }*/
        }

    }

}

