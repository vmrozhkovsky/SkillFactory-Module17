namespace OpenClosePrinciple;

public class Account
{
    // тип учетной записи
    public string Type { get; set; }
  
    // баланс учетной записи
    public double Balance { get; set; }
  
    // процентная ставка
    public double Interest { get; set; }

    public void Calculate(ICalculator calculator)
    {
        calculator.CalculateInterest(this);
    }
}