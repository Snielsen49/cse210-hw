Features

Customer Operations: Customers can enter their name and perform actions such as viewing their accounts, making deposits, 
    and making withdrawals.
Teller Operations: Teller menu allows bank employees to create customers, list customers, and add accounts to customers.
Account Types: The system supports two types of accounts: savings and checkings.
Transaction Tracking: Transactions made on accounts are recorded and can be viewed.
Password Validation: Customers are prompted for a password to ensure secure access to their accounts.
Abstraction: The code is organized into multiple classes with specific responsibilities, representing entities 
    such as customers, accounts, and transactions.
Encapsulation: The internal details of the classes are encapsulated by using private fields, 
    and public methods are provided for external interactions.
Inheritance: The Checkings and Savings account classes inherit from the base Account class to share common functionality.
Polymorphism: Methods like DisplayInfo() are defined in the base Account class and overridden in derived classes to 
    provide specialized behavior.

Class Structure

Bank: Main entry point of the program that handles the user interface and menu options.
Customer: Represents a bank customer with name, password, address, and a list of accounts.
Checkings: Represents a checking account, derived from the base Account class.
Savings: Represents a savings account, derived from the base Account class.
Account: Base class for different types of accounts, storing account-specific details and providing common methods.
Transaction: Represents a transaction made on an account, storing the amount, date, and account number.

Testing 
I have created a pre made user named bob with a password of 1234 if you would like to test the user side.  This would be to veiw
acounts and make any withdraws or diposits.  also the teller side would be used to make new acounts and see existing acounts 
or add acounts to existing users.

