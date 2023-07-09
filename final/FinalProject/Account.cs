public class Account
{
    protected List<Transaction> transactions = new List<Transaction>();
    private Double bal;
    protected Customer customer;
    protected int actnum;
    private string type; 
    
    public Account(double startbal, Customer startcustomer, int acountNum, string typ)
    {
        bal = startbal;
        customer = startcustomer;
        actnum = acountNum;
        type = typ;
    }

    public virtual void DisplayInfo()
    {
       Console.WriteLine($"Account number: {actnum}");
       Console.WriteLine($"Curent balance: ${bal}");
       Console.WriteLine("Recent transactions:");
       listtransactions();
       Console.WriteLine("Press enter when finished");
       Console.ReadLine();
    }
    public double GetBal()
    {
        return bal;
    }
    public string GetAccountType()
    {
        return type;
    }
    public void SetBal(double amount)
    {
        bal = amount;
    }
    public void Deposit(double amount)
    {
        bal = bal + amount;
        Console.WriteLine($"Your deposit of ${amount} is complete!");
        Transaction newtrans = new Transaction(amount,actnum);
        transactions.Add(newtrans);
    }
    public virtual void Withdraw(double amount)
    {
        if (amount > bal)
        {
            Console.WriteLine("Sorry but the amount entered is more than the curent balance.");
            Console.WriteLine("Please try again with a smaller amount.");
        }
        else
        {
            bal = bal - amount; 
            Console.WriteLine($"Your withdraw of ${amount} is complete!");
            Transaction newtrans = new Transaction(-amount,actnum);
            transactions.Add(newtrans);
        }
    }
    public void listtransactions()
    {
        foreach (Transaction tran in transactions)
        {
            tran.Display();
        }
    }
    
}