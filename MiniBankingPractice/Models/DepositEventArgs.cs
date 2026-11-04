using System;

namespace MiniBankingPractice.Models;

public class DepositEventArgs : EventArgs
{

public decimal Amount {get;}

//constructor

public DepositEventArgs(decimal amount)
    {
        Amount = amount;
    }

}
