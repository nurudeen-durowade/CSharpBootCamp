using System;




class Program
{
    static void Main()
    {
        int [,] matrix = new int[3, 3];
        
        int [,] marks =
        {
            { 90, 85, 80 },
            { 75, 70, 65 },
            { 60, 55, 50 }
        };
       
        //Console.WriteLine($"marks[0, 0]: {marks[0, 0]}");

        int [,] array2DDeclaration = new int[4,2];

        int [,] arrray2DInitialization = {{ 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }};

        Console.WriteLine($"arrray2DInitialization[2, 1]: {arrray2DInitialization[2, 1]}");

        //Three-dimensional array declaration and initialization    

        int [,,] array3DDeclaration = new int[2,3,4];

        int [,,] array3DInitialization = new int[3,5,4]
        {
            { 
            { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 },
            { 17, 18, 19, 20 }
            },
            { 
            { 13, 14, 15, 16 }, 
            { 17, 18, 19, 20 }, 
            { 21, 22, 23, 24 },
            { 25, 26, 27, 28 },
            { 29, 30, 31, 32 }
            },
            { 
            { 25, 26, 27, 28 }, 
            { 29, 30, 31, 32 }, 
            { 33, 34, 35, 36 },
            { 37, 38, 39, 40 },
            { 41, 42, 43, 44 }
            }
        };

    Console.WriteLine($"array3DInitialization[1, 2, 3]: {array3DInitialization[1, 2, 3]}");
    Console.WriteLine($"array3DInitialization[0, 1, 2]: {array3DInitialization[0, 1, 2]}");


// Jagged array declaration and initialization
        int [][] floparray = [[1, 2, 3], [4, 5], [6, 7, 8, 9], [10, 11]];

        Console.WriteLine($"floparray[2][3]: {floparray[2][3]}");


        int[][] jaggedArray = [[1, 2, 3], [4, 5], [6, 7, 8, 9]];

    Console.WriteLine($"jaggedArray[2][3]: {jaggedArray[2][3]}");
    Console.WriteLine("jaggedArray[1][1] is: {0}", jaggedArray[1][1]);
    
    //Assign 77 to the last element of the second array in jaggedArray

    jaggedArray[1][^1] = 77;

   int[][,] jaggedArray3  = [
       new int[,] { { 1, 2 }, { 3, 4 } },
       new int[,] { { 5, 6 }, { 7, 8 } },
       new int[,] { { 9, 10 }, { 11, 12 } }
   ];

    Console.WriteLine($"jaggedArray3.Length: {jaggedArray3.Length}");

    
    }


}