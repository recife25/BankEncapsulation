//Felipe Ruiz 
//Encapsulation Bank app
using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
           var account = new BankAccount();
            //BankAccount account = new BankAccount();
            Console.WriteLine("Amount to deposit");
            var amountToDep = double.Parse(Console.ReadLine());
            account.Deposit(amountToDep);
            Console.WriteLine($"Thank you Your balance is now {account.GetBalance()}");
            
        }
    }
}
