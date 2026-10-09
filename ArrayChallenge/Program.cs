using System;

class Program
{
    static void Main()
    {
        // string[] productNames = ["Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape"];

        // double[] productPrices = [1.0, 0.5, 3.0, 4.5, 5.0, 6.0, 7.0];

        // double totalPrice = 0;

        // for (int i = 0; i < productNames.Length; i++)
        // {
        //     Console.WriteLine($"Product: {productNames[i]:F1}, Price: ${productPrices[i]:F1}");
        //     totalPrice += productPrices[i];
        // }

        // Console.WriteLine($"Total Price: ${totalPrice:F1}");
        // }

    //Product List

    string [] productLists = new string[] {"Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape"};

    //Product Prices

    double [] productPrices = new double[] {1.0, 0.5, 3.0, 4.5, 5.0, 6.0, 7.0};

    //Display Product List and Prices

    Console.WriteLine("Product List and Prices:");

    Console.WriteLine("-------------------------");

    Console.WriteLine($"{productLists[0]}: ${productPrices[0]:F1}");
    Console.WriteLine($"{productLists[1]}: ${productPrices[1]:F1}");
    Console.WriteLine($"{productLists[2]}: ${productPrices[2]:F1}");
    Console.WriteLine($"{productLists[3]}: ${productPrices[3]:F1}");
    Console.WriteLine($"{productLists[4]}: ${productPrices[4]:F1}");
    Console.WriteLine($"{productLists[5]}: ${productPrices[5]:F1}");
    Console.WriteLine($"{productLists[6]}: ${productPrices[6]:F1}");


    double[] ShoppingCart = new double[] { productPrices[0], productPrices[2], productPrices[4], productPrices[6] };

    Console.WriteLine("\nShopping Cart:");

    Console.WriteLine("-------------------------");

    Console.WriteLine($"{productLists[0]}: ${ShoppingCart[0]:F1}");
    Console.WriteLine($"{productLists[2]}: ${ShoppingCart[1]:F1}");
    Console.WriteLine($"{productLists[4]}: ${ShoppingCart[2]:F1}");
    Console.WriteLine($"{productLists[6]}: ${ShoppingCart[3]:F1}"); 

    double totalPrice = ShoppingCart[0] + ShoppingCart[1] + ShoppingCart[2] + ShoppingCart[3];
    Console.WriteLine($"\nTotal Price: ${totalPrice:F1}");
    
    }


    }
