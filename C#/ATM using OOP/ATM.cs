class ATM
    {
        string userName;
        double balance = 0;

        public ATM (string userName, double balance)
        {
            this.userName = userName;
            this.balance = balance;
        }
        public void Display()
        {
            Console.WriteLine($"Hello {this.userName} you can Deposit by writing 1");
            Console.WriteLine("you can Withdraw by writing 2");
            Console.WriteLine("you can check balance by writing 3");
            Console.WriteLine("you can exit ATM by writing 4: ");
            while (true)
            {
                double UserInput = double.Parse(Console.ReadLine());

                if (UserInput == 1)
                {

                    Deposit();
                }
                else if(UserInput == 2)
                {
                    Withdraw();
                }
                else if (UserInput == 3)
                {
                    Console.WriteLine($"your current balance is {this.balance}!");
                }
                else if(UserInput == 4)
                {
                    break;
                }

            }
        }

        public void Deposit()
        {
            Console.WriteLine("how much do you want to deposit? : ");
            double deposit = double.Parse(Console.ReadLine());
            this.balance += deposit;
            Console.WriteLine($"You Deposited {deposit} to the current balance!");
        }

        public void Withdraw()
        {
            Console.WriteLine("How much do you want to Withdraw? : ");
            double UserWithdraw = double.Parse(Console.ReadLine());
            if (UserWithdraw > this.balance )
            {
                Console.WriteLine("you can't withdraw more than the current balance!");
           return;
 }
 else
 {
 this.balance -= UserWithdraw;
 Console.WriteLine($"You Withdrawed {UserWithdraw} from the current balance!");
            }
}
}
class Program
{
    public static void Main(string[] args)
    {
        ATM atmSmall = new ATM("Ahmed",2000);
        atmSmall.Display();

    }


}
