
namespace MiniBankingPractice.DTOs;

public record DepositRequest
(
    string AccountNumber,
    decimal Amount,
    string Description
);
