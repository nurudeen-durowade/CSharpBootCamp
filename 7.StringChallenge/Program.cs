using System;

class Program
{
    static void Main(string[] args)
    {
      // Two similar methods StartWith and EndsWith are used to check if a string starts or ends with a specific substring.

      string songLyrics = "Twinkle, twinkle, little star, How I wonder what you are! Up above the world so high, Like a diamond in the sky.";
    
        Console.WriteLine($"Song Lyrics: {songLyrics.StartsWith("Twinkle")}");

        Console.WriteLine($"Song Lyrics: {songLyrics.EndsWith("sky.")}");

        Console.WriteLine($"Song Lyrics: {songLyrics.StartsWith("Bloom!")}");

        Console.WriteLine($"Song Lyrics: {songLyrics.EndsWith("moon.")}");
    }
}