using System;
namespace ClassesAndObj.Models;

public class FeePrinter
{
    public static void PrintMonthlyFee(IMonthlyFeeCalculator account)
    {
        Console.WriteLine($"Monthly Fee: {account.CalculateMonthlyFee()}");
    }
}