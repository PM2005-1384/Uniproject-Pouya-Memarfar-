
using System.Runtime.InteropServices;

namespace ConsoleApp13;
public class Encode
{
    public static int LetterToNum(char c)
    {
        if (char.IsLower(c))
        return c - 'a' + 1;
        else if (char.IsUpper(c))
        return c - 'A' + 27;
        else
        throw new ArgumentException("No alphabetic character");
    }
    public static int NameSum(string name)
    {
        int sum = 0;
        foreach (char c in name)
        {
            if (char.IsLetter(c))
            sum += LetterToNum(c);
        }
        return sum;
    }
    public static string EncodeCommunication1(string message, int shift)
    {
        char[] encodedMessage = new char[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
            char c = message[i];
            if (char.IsLower(c))
            {
                encodedMessage[i] = (char)(((c - 'a' + shift) % 26 + 26) % 26 + 'a');
            }
            else if (char.IsUpper(c))
            {
                encodedMessage[i] = (char)(((c - 'A' + shift) % 26 + 26) % 26 + 'A');
            }
            else
            {
                encodedMessage[i] = c;
            }
        }
        return new string(encodedMessage);
    }
    public static int EncodeCommunication2(int sum_sender, int sum_receive)
    {
        int m = sum_sender * sum_receive;
        int t = sum_sender + sum_receive;

        return m/t;
    }

    public static void Save(string encodedmessage)
    {
        string csv_file = "encoded message.csv";
        File.WriteAllText(csv_file, "Encoded Message\n");
        File.AppendAllText(csv_file, $"\"{encodedmessage}\"n");

        string txt_file = "encoded message.txt";
        File.WriteAllText(txt_file, encodedmessage);
    }

    public static string Load(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error, failed to load file:{ex.Message}");
            return string.Empty;
        }
    }

}
