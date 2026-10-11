using System;

class Program
{
    static void Main()
    {
        string transactionStatus = "Successful";

        switch (transactionStatus){
            case "Successful":
                Console.WriteLine("The transaction was successful.");
                break;
            case "Pending":
                Console.WriteLine("The transaction is pending. Please wait for confirmation.");
                break;
            case "Failed":
                Console.WriteLine("The transaction failed. Please try again later.");
                break;
            default:
                Console.WriteLine("Unknown transaction status.");
                break;
        }


        int transactionCode = 2;

        switch (transactionCode){
            case 1:
                Console.WriteLine("Transaction code 1: Payment processed.");
                break;
            case 2:
                Console.WriteLine("Transaction code 2: Payment pending.");
                break;
            case 3:
                Console.WriteLine("Transaction code 3: Payment failed.");
                break;
            default:
                Console.WriteLine("Unknown transaction code.");
                break;
        }

        string message = transactionStatus switch
        {
            "Successful" => "The transaction was successful.",
            "Pending" => "The transaction is pending. Please wait for confirmation.",
            "Failed" => "The transaction failed. Please try again later.",
            _ => "Unknown transaction status."
        };
        Console.WriteLine(message);
    }
}
