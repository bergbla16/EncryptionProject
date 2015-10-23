using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionProject
{
    public abstract class TextEncryption {

        public string algorithmName;


        private static int encryptionKey;

        public abstract string getInfo(); //Returns description of algorithm
        public abstract string encrypt(string inputMessage); //Takes text, and returns an encrypted version of the text
        public abstract string decrypt(string encryptedMessage); // Takes an encrypted text and returns original text using key



    }
    public class CaesarCypher : TextEncryption
    {
        private const int[] EXCEPTIONS = new int[1] {32};
        private const int LOWER_ASCII_BOUND = 97;
        private const int UPPER_ASCII_BOUND = 122;
        public string algorithmName = "Caesar Cypher/Substitution";

        private int encryptionKey;
        private int shiftAmount;

        public CaesarCypher(int shift) 
        {
            this.shiftAmount = shift;
        }

        public CaesarCypher(int shift, int encryptionKey)
        {
            this.shiftAmount = shift;
            this.encryptionKey = encryptionKey;
        }



        public override string getInfo()
        {
            return "Performs a Caesar substitution on the given message";
        }

        public override string encrypt(string inputMessage)
        {
            byte[] asciiMessage = Encoding.ASCII.GetBytes(inputMessage.ToLower());
            byte[] newAsciiMessage = new byte[inputMessage.Length];
            for (int i = 0; i < asciiMessage.Length; i++)
            {
                if (asciiMessage[i] >= LOWER_ASCII_BOUND && asciiMessage[i] <= UPPER_ASCII_BOUND)
                {
                    if (asciiMessage[i] > (UPPER_ASCII_BOUND - shiftAmount)){
                        int shiftAfterOverflow = shiftAmount - (UPPER_ASCII_BOUND - asciiMessage[i]) - 1;
                        byte newAsciiValue = (byte)(LOWER_ASCII_BOUND + shiftAfterOverflow);
                        newAsciiMessage[i] = (newAsciiValue);
                    }
                    else
                    {
                        byte newAsciiValue = (byte)(asciiMessage[i] + shiftAmount);
                        newAsciiMessage[i] = newAsciiValue;
                    }
                }
            }
            return Encoding.ASCII.GetString(newAsciiMessage);
        }


        public override string decrypt(string encryptedMessage)
        {
            return "not implemented yet";
        }
    }
    public class TestClient
    {
        static void Main(String[] args)
        {
            Console.Write("Program started");
            CaesarCypher message1 = new CaesarCypher(5);
            Console.WriteLine(message1.encrypt("abcdefghijklmnopqrstuvwxyz");
        }

    }
}
