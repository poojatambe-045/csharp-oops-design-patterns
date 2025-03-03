using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Encapsulation
    {
        static void Main()
        {
            BankAccount myAccount = new BankAccount(1000);

            myAccount.Deposit(500);
            Console.WriteLine("Balance: " + myAccount.GetBalance());

            myAccount.Withdraw(2000);
            Console.WriteLine("Balance: " + myAccount.GetBalance());


            BankAccount myAccount2 = new BankAccount(2000);

            myAccount2.Deposit(500);
            Console.WriteLine("Balance: " + myAccount2.GetBalance());

            myAccount2.Withdraw(700);
            Console.WriteLine("Balance: " + myAccount2.GetBalance());
        }
    }
}


//output
//Balance: 1500
//Insufficient funds.
//Balance: 1500

//Balance: 2500
//Balance: 1800
