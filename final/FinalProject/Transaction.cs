public class Transaction
{
    private double amount;
    private DateTime date;
    private int account;
    public Transaction(double amt, int act)
    {
        amount = amt;
        account = act;
        date = DateTime.Now;
    }
    public void Display()
    {
        if (amount < 0) 
        {
            amount = -amount;
            Console.WriteLine($"${amount} was drawn from acount number {account} on {date}");
        }
        else
        {
            Console.WriteLine($"${amount} was deposited to acount number {account} on {date}");
        }
       
    }
}