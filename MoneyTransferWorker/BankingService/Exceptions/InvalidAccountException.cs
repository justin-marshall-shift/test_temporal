namespace Temporalio.MoneyTransferProject.BankingService.Exceptions;

public class InvalidAccountException(string message) : Exception(message)
{
}
