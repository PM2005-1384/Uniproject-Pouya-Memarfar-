using System;

namespace ConsoleApp13;

public class Decode: Encode
{
    public static string DecodeCommunication(string message, int shift)
    {
        char[] decodedMessage = new char[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
            char c = message[i];
            if (char.IsLower(c))
            {
                decodedMessage[i] = (char)(((c - 'a' - shift) % 26 + 26) % 26 + 'a');
            }
            else if (char.IsUpper(c))
            {
                decodedMessage[i] = (char)(((c - 'A' - shift) % 26 + 26) % 26 + 'A');
            }
            else
            {
                decodedMessage[i] = c;
            }
        }
        return new string(decodedMessage);
    }
    
}
