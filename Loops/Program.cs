using System;


class Program
{
    
    static void Main()
    {

        // while loop 
        int counter = 0;

        while (counter < 10)
        {
            Console.WriteLine($"Counter: {counter}");

            counter++;
        }
// do - while Loop 

        do
        {
           Console.WriteLine($"Hello world!, the  counter is: {counter}"); 

           counter++;

        } while (counter < 10);

//For Loop

        for(int i  = 1; i <= 5; i++)
        {
            Console.WriteLine($"Transaction{i}");
        }

        // ForEach


        decimal[] transactions = [1000m, 2000m, 5000m];


        foreach (decimal amount in transactions)
        {
            Console.WriteLine(amount);
            
            
        }
        
    }
}