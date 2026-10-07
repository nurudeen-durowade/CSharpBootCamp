using System;

class Program
{
    static void Main(string[] args)
    {
        string myName = "Nurudeen";

        Console.WriteLine("My name is " + myName);


        string myFriendName = "Abdulazeez";

        string myBestFriendName = "Qasim";

        //$ is used to format the string and insert the values of variables into the string. It allows for easier and more readable string interpolation.

        Console.WriteLine($"My friend's name is {myFriendName} and my best friend's name is {myBestFriendName}");
    }
}
