using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello User!");
        Console.WriteLine("Please enter the message you would like to post to Twitter:");
        string message = Console.ReadLine();
        if (message.Length <= 140)
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }
    }
}