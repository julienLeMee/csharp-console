using System

puclic class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardName, int pin, string firstName, string lsatName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public static void main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder, currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit: ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance += depositAmount;
            Console.WriteLine("Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder, currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            // check if user has enough money
            if (currentUser.getBalance() > withdrawal)
            {
                currentUser.setBalance -= withdrawal;
                Console.WriteLine("Your new balance is: " + currentUser.getBalance());
            }
            else
            {
                Console.WriteLine("You do not have enough money to withdraw that amount.");
            }
        }

        void balance(cardHolder, currentUser)
        {
            Console.WriteLine("Your current balance is: " + currentUser.getBalance());
        }

        // chiffre aleatoire de 16 chiffres:
        Random rand = new Random();
        int cardNumber = rand.Next(1000000000000000, 9999999999999999);

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.add(new cardHolder("0123456789101112", 1234, "John", "Smith", 150.30));
        cardHolders.add(new cardHolder(cardNumber.ToString(), 4321, "Jane", "Doe", 321.13));
        cardHolder.add(new cardHolder(cardNumber.ToString(), 1111, "Bob", "Jones", 105.60));
        cardHolder.add(new cardHolder(cardNumber.ToString(), 2222, "Sally", "Smith", 851.84));
        cardHolder.add(new cardHolder(cardNumber.ToString(), 3333, "Joe", "Johnson", 54.77));

        // Welcome message
        Console.WriteLine("Welcome to simple ATM!");
        Console.WriteLine("Please enter your debit card: ");
        String debitCardNumber = "";
        cardHolder currentUser;

        // check if card number is valid
        while (true)
        {
            try
            {
                debitCardNumber = Console.ReadLine();
                // check against our db
                currentUser = cardHolders.FirstOrDefault(x => x.cardNum == debitCardNumber);
                if (currentUser != null)
                {
                  break;
                }
                else
                {
                    Console.WriteLine("Invalid card number. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid card number. Please try again.");
            }
        }

        // ask for pin
        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;

        // check if pin is valid
        while (true)
        {
            try
            {
                userPin = Int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin)
                {
                  break;
                }
                else
                {
                    Console.WriteLine("Invalid pin. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid pin. Please try again.");
            }

        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + "!");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = Int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        deposit(cardHolder, currentUser);
                        break;
                    case 2:
                        withdraw(cardHolder, currentUser);
                        break;
                    case 3:
                        balance(cardHolder, currentUser);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our ATM!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        } while (option != 4); // because 4 is the exit option
        Console.WriteLine("Goodbye!");

}
