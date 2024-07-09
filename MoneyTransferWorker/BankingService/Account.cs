namespace Temporalio.MoneyTransferProject.MoneyTransferWorker;
public class Account(string accountNumber, int balance)
{
    public string AccountNumber { get; private set; } = accountNumber;
    public int Balance { get; set; } = balance;
}