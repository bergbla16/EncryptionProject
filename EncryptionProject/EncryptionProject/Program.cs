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
        public abstract string decrypt(string encryptedMessage); // Takes an encrypted text and returns original text 



    }
    public class CaesarCypher : TextEncryption
    {
        public string algorithmName = "Caesar Cypher/Substitution";

        private int encryptionKey;
        private int shiftAmount = 6;

        public override string getInfo()
        {
            return "Performs a Caesar substitution on the given message";
        }

        public override string encrypt(string inputMessage)
        {

        }
        
        private string[] FindCorrespondingLetter()
        {
            string[] shiftedLetterArray = new string[26];
            foreach (string letter in shiftedLetterArray)
            {

            }
        }
    }
}
