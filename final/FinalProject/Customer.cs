public class Customer
{
    private string name;
    private string password;
    private string address;
    private List<Account> accounts = new List<Account>();
    public Customer(string setname,string setaddress, string setpassword)
    {
        name = setname;
        password = setpassword;
        address = setaddress;
    }
    public void AddAccount(Account newacount)
    {
        accounts.Add(newacount);
    }
    public string GetName()
    {
        return name;
    }
    public string Getpassword()
    {
        return password;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"customer name: {name}");
        Console.WriteLine($"customer address: {address}");
    }
    public void DisplayAccountInfo(int actnum)
    {
        accounts[actnum].DisplayInfo();
    }
    public void AccountDeposit(int actnum)
    {
        Console.WriteLine("How much would you like to deposit in dollers?");
        double amount = double.Parse(Console.ReadLine());
        accounts[actnum-1].Deposit(amount);
    }
     public void AccountWithdraw(int actnum)
    {
        Console.WriteLine("How much would you like to withdraw in dollers?");
        double amount = double.Parse(Console.ReadLine());
        accounts[actnum-1].Withdraw(amount);
    }
    public void ListAcounts()
    {
        int i = 1;
        foreach (Account act in accounts)
        {
            Console.WriteLine($"{i}. {act.GetAccountType()}");
            i++;
        }
    }
    public int CountAccounts()
    {
        return accounts.Count();
    }
    public bool CheckUser()
    {
        Console.WriteLine("Please enter Your password:");
        bool run = true;
        while (run)
        {
            string test = Console.ReadLine();
            if (test == password )
            {
                return true;
            }
            else if (test == "quit")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("That was a incorect password. Please enter the corect password or enter quit to quit:");
            }
        }
        return false;
    }
}