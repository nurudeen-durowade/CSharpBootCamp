namespace MiniBankingPractice.Models;


public class TransactionReferenceTracker
{
    private readonly HashSet<string> _processedReference = [];

    public bool TryProcess(string? reference)
    {
        if (string.IsNullOrWhiteSpace(reference))
        {
            return false;
        }
        return _processedReference.Add(reference.Trim());
    }

}