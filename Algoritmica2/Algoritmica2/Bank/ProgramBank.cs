using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramBank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Created bank");
        Bank bank = new Bank();

        var banana = bank.Register("Banana");
        Console.WriteLine($"{banana.name} has been registered");
        var koton = bank.Register("Kotoooooon");
        Console.WriteLine($"{koton.name} has been registered");

        banana.Deposit(420);
        koton.Deposit(34);
        banana.Withdraw(69);

        Console.WriteLine($"{banana.name}'s money: {banana.money}");
        Console.WriteLine($"{koton.name}'s money: {koton.money}");

    }
}
