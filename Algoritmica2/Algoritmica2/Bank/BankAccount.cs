using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public string name { get; set; }
    public float money { get; private set; }
    public void Deposit(float money)
    {
        if (money < 0) throw new FormatException();
        this.money += money;
    }
    public void Withdraw(float money)
    {
        if(money > this.money) throw new NotEnoughMoneyException();
        this.money -= money;
    }
    class NotEnoughMoneyException : Exception { }
}
