namespace MiniBankingPractice.DTOs;

public record DepositResponse
(
    Guid TransactionId,
    string AccountNumber,
    decimal AmountDeposited,
    decimal NewBalance,
    string Description,
    DateTime Timestamp
);