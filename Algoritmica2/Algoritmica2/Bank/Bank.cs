using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bank
{
    Dictionary<string,BankAccount> bankAccounts = new Dictionary<string, BankAccount>();
    public BankAccount GetAccount(string name)
    {
        return bankAccounts[name];
    }
    public BankAccount Register(string name)
    {
        var account = new BankAccount();
        account.name = name;
        bankAccounts.Add(name, account);
        return account;
    }
}
