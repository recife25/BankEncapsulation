//Felipe Ruiz 
//Encapsulation Bank app
using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        //constructor and special member method
        public BankAccount()
        {

        }
        //fields are like a var in our class
        private double balance = 0;

        //define a method named Deposit that will accept a double 
        //and store that value in the balance field.
        //void is used to get a value a place it in balance

        //here is the encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
        }

        //define a method named GetBalance that will return the amount 
        //stored in the balance field
        public double GetBalance()
        {
            return balance;
        }


        
    }
}
