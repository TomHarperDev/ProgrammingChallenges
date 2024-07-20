using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class CeaserCipher
    {
        public String alphabet = ("abcdefghijklmnopqrstuvwxyz");
        public CeaserCipher(string message)
        {
            Console.WriteLine(Encrypt("hello world z", 1));
            Console.WriteLine(Decrypt("ifmmp az", 1));
        }
        public string Encrypt(string message, int key)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    encryptedMessage.Append(' ');
                }
                int newitem = (alphabet.IndexOf(message[i]) + key) % 26;
                encryptedMessage.Append(alphabet[newitem]);
            }
            return encryptedMessage.ToString();
        }
        public string Decrypt(string message, int key)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            for(int i = 0;i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    decryptedMessage.Append(' ');
                }
                int newitem = (alphabet.IndexOf(message[i]) - key + 26) % 26;
                decryptedMessage.Append(alphabet[newitem]);
            }
            return decryptedMessage.ToString();
        }
    }
}
