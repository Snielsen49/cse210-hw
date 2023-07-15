using System;

class Program
{
    static void Main(string[] args)
    {
        int ans;
        int i = 0;
        bool run = true;
        bool main = true;
        int customernum = -1;
        List<Customer> customers = new List<Customer>();

        Customer bob = new Customer("Bob", "1234", "123 Main St");
        customers.Add(bob);

       
        Checkings checking = new Checkings(1000, bob, 1);
        bob.AddAccount(checking);
        Savings savings = new Savings(5000, bob, 2);
        bob.AddAccount(savings);
        checking.Deposit(500);
        checking.Withdraw(200);
        savings.Deposit(1000);
        savings.Withdraw(500);
        

        while (main)
        {
            Console.Clear();
            Console.WriteLine($"Welcome!\nPlease select a user\n1.Customer\n2.Teller\n3.Quit");
            ans = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (ans)
            {
                case 1:
                {
                    run = true;
                    while (run)
                    {
                        customernum = -1;
                        Console.WriteLine("Please enter your name:");
                        string name = Console.ReadLine();
                        
                        int j = 0;
                        foreach (Customer cust in customers)
                        {
                            
                            string testname = cust.GetName();
                            if (name == testname)
                            {
                                customernum = j; 
                            }
                            else
                            {
                                j++;
                            }
                        }
                        if (customernum != -1)
                        {
                            
                            if (customers[customernum].CheckUser())
                            {
                                while(run)
                                {
                                Console.Clear();
                                Console.WriteLine($"Welcome {customers[customernum].GetName()}!");
                                Console.WriteLine($"Please Select a option:\n1.View a acount\n2.Make a deposit\n3.Make a withdraw\n4.Quit");
                                ans = int.Parse(Console.ReadLine());
                                switch (ans)
                                {
                                    case 1:
                                    {
                                        Console.WriteLine("Please Select a acount:");
                                        customers[customernum].ListAcounts();
                                        ans = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        customers[customernum].DisplayAccountInfo(ans-1);
                                        break;
                                    }
                                    case 2: 
                                    {
                                        Console.WriteLine("Please Select a acount:");
                                        customers[customernum].ListAcounts();
                                        ans = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        customers[customernum].AccountDeposit(ans);
                                        break;
                                    }
                                    case 3:
                                    {
                                        Console.WriteLine("Please Select a acount:");
                                        customers[customernum].ListAcounts();
                                        ans = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        customers[customernum].AccountWithdraw(ans);
                                        break;
                                    }
                                    case 4:
                                    {
                                        run = false;
                                        break;
                                    }
                                    
                                }

                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no users with that name Please try again by pressing enter or type quit to quit");
                            string check = Console.ReadLine();
                            if (check == "quit")
                            {
                                break;
                            }
                        }

                    }
                    break;
                }
                case 2:
                {
                    bool tellerrun = true;
                    while (tellerrun)
                    {
                        Console.Clear();
                        Console.WriteLine($"Teller menu:\n1.Create a customer\n2.List customers\n3.Add a acount to a customer\n4.Quit");
                        ans = int.Parse(Console.ReadLine());
                        switch (ans)
                        {
                            case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("What is the name of the customer:");
                                string newname = Console.ReadLine();
                                Console.WriteLine("What is the password for the new customer:");
                                string newpassword = Console.ReadLine();
                                Console.WriteLine("What is their address:");
                                string newaddress = Console.ReadLine();
                                Customer newcustomer = new Customer(newname,newaddress,newpassword);
                                customers.Add(newcustomer);
                                bool addacount = true;
                                while (addacount)
                                {
                                    Console.WriteLine($"What acount type would you like to create:\n1.Savings\n2.Checking");
                                    ans = int.Parse(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                        {
                                            Console.WriteLine("What is the starting balance:");
                                            double newbal = double.Parse(Console.ReadLine());
                                            Savings newaccount = new Savings(newbal,newcustomer,1);
                                            newcustomer.AddAccount(newaccount);
                                            addacount = false;
                                            break;
                                        }
                                        case 2:
                                        {
                                            Console.WriteLine("What is the starting balance:");
                                            double newbal = double.Parse(Console.ReadLine());
                                            Checkings newaccount = new Checkings(newbal,newcustomer,1);
                                            newcustomer.AddAccount(newaccount);
                                            addacount = false;
                                            break;
                                        }
                                        default:
                                        {
                                            Console.WriteLine("Please enter a viable option");
                                            break;
                                        }
                                    }
                                }

                                
                            break;
                            }
                            case 2:
                            {
                                Console.Clear();
                                foreach(Customer cus in customers)
                                {
                                    cus.DisplayInfo();
                                }
                                Console.WriteLine("Press enter when finished");
                                Console.ReadLine();
                                break;
                            }
                            case 3:
                            {
                                Console.Clear();
                                Console.WriteLine("What is the name of the customer:");
                                string customername = Console.ReadLine();
                                customernum = -1;     
                                i = 0;                           
                                foreach (Customer cust in customers)
                                {
                                   
                                    string testname = cust.GetName();
                                    if (customername == testname)
                                    {
                                        customernum = i; 
                                    }
                                    else
                                    {
                                        i++;
                                    }
                                }
                                if (customernum != -1)
                                {
                                    Console.WriteLine($"What acount type would you like to create:\n1.Checking\n2.Savings");
                                    ans = int.Parse(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                        {
                                            Console.WriteLine("What is the starting balance:");
                                            double newbal = double.Parse(Console.ReadLine());
                                            Savings newaccount = new Savings(newbal,customers[customernum],customers[customernum].CountAccounts() + 1);
                                            customers[customernum].AddAccount(newaccount);
                                            break;
                                        }
                                        case 2:
                                        {
                                            Console.WriteLine("What is the starting balance:");
                                            double newbal = double.Parse(Console.ReadLine());
                                            Checkings newaccount = new Checkings(newbal,customers[customernum],customers[customernum].CountAccounts() + 1);
                                            customers[customernum].AddAccount(newaccount);
                                            break;
                                        }
                                        default:
                                        {
                                            Console.WriteLine("Please enter a viable option");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There are no users with that name Please try again by pressing enter");
                                    Console.ReadLine();
                                    
                                }
                                break;
                            }
                            case 4:
                            {
                                tellerrun = false;
                                break;
                            }

                        }
                    }
                    break;
                }
                case 3:
                {
                    main = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("Please enter a viable option");
                    break;
                }
            }
        }
    }

}
