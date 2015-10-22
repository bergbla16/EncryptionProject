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
        public string algorithmName = "Caesar Cypher/Substitution";

        private int encryptionKey;
        private int SHIFT_AMOUNT = 6;
        private int[] EXCEPTIONS = new int[1] {32};
        private int LOWER_ASCII_BOUND = 97;
        private int UPPER_ASCII_BOUND = 122;


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
                    if (asciiMessage[i] > (UPPER_ASCII_BOUND - SHIFT_AMOUNT)){
                        int shiftAfterOverflow = SHIFT_AMOUNT - (UPPER_ASCII_BOUND - asciiMessage[i]) - 1;
                        byte newAsciiValue = LOWER_ASCII_BOUND + shiftAfterOverflow;
                        newAsciiMessage[i] = (newAsciiValue);
                    }
                    else
                    {
                        byte newAsciiValue = asciiMessage[i] + SHIFT_AMOUNT;
                        newAsciiMessage[i] = newAsciiValue;
                    }
                }
            }
            //must convert ascii values in newAsciiMessage to string, maybe using chars
        }
    }
}
