namespace b_bankactivity;

class BankAccount
{
    double balance;

    public void Deposit()
    {
        Console.Write("Enter amount to deposit:");
        double amount=double.Parse(Console.ReadLine());
        balance +=amount;
        Console.WriteLine("Deposited:"+amount);
        Console.WriteLine("New Balance:"+ balance);
    }

    public void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount > balance)
                Console.WriteLine("Insufficient funds!");
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
                Console.WriteLine("New Balance: " + balance);
            }
        }
        
    public void ShowBalance()
        {
            Console.WriteLine("Balance: " + balance);
        }
    static void Main(string[] args)
    {
       BankAccount b1 = new BankAccount();

            Console.WriteLine("1 Deposit");
            Console.WriteLine("2 Withdraw");
            Console.WriteLine("3 Show Balance");
            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                b1.Deposit();
            else if (choice == 2)
                b1.Withdraw();
            else if (choice == 3)
                b1.ShowBalance();
            else
                Console.WriteLine("Invalid option!");
        }
    }

