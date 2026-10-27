using System;
using System.Collections.Generic;
namespace MiniBankingPractice.Models;

public class RecentOperations
{
    private readonly Stack<string> _recentOperations = new();

    public bool PushOperation(string? operations)
    {
        if (string.IsNullOrWhiteSpace(operations))
        {
            Console.WriteLine("Operations cannot be empty");
            return false;
        }
        _recentOperations.Push(operations.Trim());
        return true;
    }

    public bool TryGetOperations(out string? operations)
    {
        if (_recentOperations.TryPop(out string? newOperations))
        {
            operations = newOperations;
            Console.WriteLine($"The operations Popped {operations}");
            return true;
        }
        operations = null;
        return false;
      
    }


}