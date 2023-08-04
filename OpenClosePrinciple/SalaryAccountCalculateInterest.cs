namespace OpenClosePrinciple;

public class SalaryAccountCalculateInterest : ICalculator
{
    public void CalculateInterest(Account account)
    {
        // расчет процентной ставки зарплатного аккаунта по правилам банка
        account.Interest = account.Balance * 0.5;
    }
}