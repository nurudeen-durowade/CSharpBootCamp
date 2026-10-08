using System;

class Program
{
    static void Main()
    {
        string[] names = ["Alice", "Bob", "Charlie", "Diana" ];

        string [] weekdays = new string[7];

        weekdays[0] = "Monday";
        weekdays[1] = "Tuesday";
        weekdays[2] = "Wednesday";
        weekdays[3] = "Thursday";
        weekdays[4] = "Friday";
        weekdays[5] = "Saturday";
        weekdays[6] = "Sunday";

        Console.WriteLine("weekdays:");
        foreach (string day in weekdays)
        {
            Console.WriteLine(day);
        }
    }
}



