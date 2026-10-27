namespace MiniBankingPractice.Models;


public class PendingTransactionQueue
{
    private readonly Queue<string> _transactionReferences = new();


    public  bool AddReference(string? reference)
    {
        if (string.IsNullOrWhiteSpace(reference))
        {
            Console.WriteLine("Reference cannot be empty");
            return false;
        }

        _transactionReferences.Enqueue(reference);
        return true;
    }

    public bool TryGetNextReference(out string? reference)
    {
        if (_transactionReferences.TryDequeue(out string? nextreference))
        {
            reference = nextreference;
            return true;
        }
        reference = null;
        return false;
    }
}