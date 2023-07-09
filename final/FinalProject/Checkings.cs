public class Checkings : Account
{
    public Checkings(double startbal, Customer startcustomer, int accountNum) :base (startbal,startcustomer,accountNum,"Checkings")
    {}
    public override void DisplayInfo()
    {
        Console.WriteLine($"{customer.GetName()} Checking acount info:");
        base.DisplayInfo();
    }
    public override void Withdraw(double amount)
    {
        double bal = GetBal();
        if (amount > bal)
        {
            Console.WriteLine($"Are you sure you want to withdraw ${amount}? This will result in a overdraft fee of $10. (yes/no)");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                bal = bal - (amount + 10);
                SetBal(bal);
                Console.WriteLine($"Your withdraw of ${amount} is complete!");
                Transaction newtrans = new Transaction(-amount,actnum);
                transactions.Add(newtrans);
            }
            else
            {
                Console.WriteLine("Please try again with a smaller amount.");
            }
        }
        else 
        {
            base.Withdraw(amount);
        }


    }
}