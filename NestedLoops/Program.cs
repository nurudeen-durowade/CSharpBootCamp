using System;


class Program
{
    static void Main(string[] args)
    {
        // One for loop can generate the rows:

        for (int row = 0; row < 11; row++)
        {
            Console.WriteLine($"The row is {row}");
        }


        // Another loop can generate the columns:
        for (char column ='a'; column < 'k'; column++)
        {
            Console.WriteLine($"The column is {column}");
        }


        //Represent on a Nested Loop

        for (int row = 0; row < 11; row++)
        {
            for (char column ='a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }
    }
}