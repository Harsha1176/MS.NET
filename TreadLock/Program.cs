using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreadLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(5000);
            Console.WriteLine(account.Balance);
            account.WithDraw(2000);
            Console.WriteLine(account.Balance);
            
            account.Tranfer(1000.00,0);
            Console.ReadKey();
        }
    }



    public class BankAccount
    {
        private double balance = 0;
        private object lockobject = new object();
        public double Balance { get { return balance; } }
        public void Deposit(double amount)
        {
            lock (lockobject)
            {
                balance += amount;
               
            }
            
        }
        public void WithDraw(double amount)
        {
            Monitor.Enter(lockobject);
            try
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    throw new Exception("Invalid Fund");
                }
            }
            catch (Exception ex)
            {

            }
            finally { Monitor.Exit(lockobject); }

        }
        public void Tranfer(double amount, BankAccount totranfer)
        {
            double currentbalance = Interlocked.Exchange(ref amount, balance - amount);
            if (currentbalance >= balance)
            {
                totranfer.Deposit(amount);
              
            }
            else
            {
                Interlocked.Exchange(ref balance, currentbalance);
                throw new Exception("Invalid Fund");
               
            }
               
        }
    }





}
