namespace OpenClosePrinciple;

class Program
{
    static void Main(string[] args)
    {
        var account = new Account();
        if (account.Type == "Обычный")
            account.Calculate(new RegularAccountCalculateInterest());
        else if (account.Type == "Зарплатный")
            account.Calculate(new SalaryAccountCalculateInterest());
    }    
}