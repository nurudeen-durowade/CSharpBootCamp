using System;


class Program
{
    static void Main(string[] args)
    {
        int accoutBalance = 50000;

        int transferAmount = 10000;

        string result;


        if (accoutBalance >= transferAmount)
        {
            result = "Transfer Approved";
        }
        else
        {
            result = "Transfer Rejected";
        }

        Console.WriteLine(result);



        
    //Ternary operator version
        //condition ? valueIfTrue : valueIfFalse
        result = accoutBalance >= transferAmount ? "Transfer Approved" : "Transfer Rejected";

        Console.WriteLine(result);


         int age = 20;

         string category = age >= 18 ? "Adult" : "Minor";

         Console.WriteLine(category);



         decimal purchaseAmount = 50000m;

         decimal discount = purchaseAmount >= 30000m ? 5000m : 0.05m;

        Console.WriteLine($"Discount: {discount}");
    
   
    }




}
