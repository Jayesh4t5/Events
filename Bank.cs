using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventsExam
{



    //    Create a Bank class
    //    Initialize balance in the constructor
    //Class must have two methods 1. Credit 2. Debit
    //If User debit the amount which is greater than balance , raise an event “Insufficient balance”
    //If balance is less than 3000, raise an event “Low balance”
    //If balance is zero then raise an event “Zero balance”

    //Credit will add amount to the balance




    public delegate void delegateHandler();
    public class Bank
    {
        public int Balance;
        public int Amount;
        public event delegateHandler lowBalanace;
        public event delegateHandler zerobalance;
        public event delegateHandler insufficientbal;


        public Bank(int balance)
        {
            this.Balance = balance;

        }
        public void Debit(int Amount)
        {
            if (Balance == 0)
            {
                zerobalance();
            }
            else if (Balance < Amount)
            {
                insufficientbal();
            }
            else if (Balance > Amount)
            {
                Balance = Balance - Amount;
                if (Balance == 0)
                {
                    zerobalance();
                }
                else if (Balance < 3000)
                {
                    lowBalanace();
                }
                Console.WriteLine($"Your Balance is :{Balance} Rs");
            }
        }

        public void credit(int Amount)
        {
            Balance += Amount;

            Console.WriteLine($"Your Account Balance is :{Balance} Rs");
        }


    }
}

