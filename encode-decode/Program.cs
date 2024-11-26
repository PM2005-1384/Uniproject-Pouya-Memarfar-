using ConsoleApp13;


    Console.WriteLine("Sender:");
    string Sender = Console.ReadLine();
    Console.WriteLine("Receiver:");
    string Receiver = Console.ReadLine();

    int S = Encode.NameSum(Sender);
    int R = Encode.NameSum(Receiver);

    int Shift1 = S + R;
    int Shift2 = Encode.EncodeCommunication2(S,R);

    Console.WriteLine("Enter the path to the encoded .txt or the encode .csv file:");
        string filePath = Console.ReadLine();
        string encodedMessage = Encode.Load(filePath);

        if (string.IsNullOrEmpty(encodedMessage))
        {
            Console.WriteLine("No encoded message found or error loading file.");
            return;
        }
        
    Console.WriteLine("\nEnter the shift method (1 for Shift 1, 2 for Shift 2):");
        int decodeChoice = int.Parse(Console.ReadLine());

        string decodedMessage = "";
        if (decodeChoice == 1)
        {
            decodedMessage = Decode.DecodeCommunication(decodedMessage, Shift1);
        }
        else if (decodeChoice == 2)
        {
            decodedMessage = Decode.DecodeCommunication(decodedMessage, Shift2); 
        }
        else
        {
            Console.WriteLine("Invalid choice for decoding.");
            return;
        }