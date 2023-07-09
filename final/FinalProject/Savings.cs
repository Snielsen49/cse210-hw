public class Savings : Account 
{
    private DateTime start;
    public Savings (double startbal, Customer startcustomer, int accountNum) :base (startbal,startcustomer,accountNum,"Savings")
    {
        start = DateTime.Now;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"{customer.GetName()} savings acount info:");
        CalcIntrest();
        base.DisplayInfo();
    }
    public void CalcIntrest()
    {
        TimeSpan timeSpan = DateTime.Now - start;
        int months = (DateTime.Now.Year - start.Year) * 12 + (DateTime.Now.Month - start.Month);
        if (months > 0)
        {
            double bal = GetBal();
            bal = bal + months * 0.025 * bal;
            start = DateTime.Now;
        }
    }
   
}