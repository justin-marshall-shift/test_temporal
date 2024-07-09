namespace Temporalio.MoneyTransferProject.BankingService.Exceptions;

public class InsufficientFundsException(string message) : Exception(message)
{
}