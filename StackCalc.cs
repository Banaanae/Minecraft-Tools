using System;

namespace StackCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Calculator\n");
            
            while (true)
            {
                Console.Write("Enter item amount: ");
                double itemAmount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter max stack: ");
                double maxStack = Convert.ToDouble(Console.ReadLine());
                double stackAmount = Math.Floor(itemAmount / maxStack);
                double stackRemainder = itemAmount % maxStack;
                double shulkerBoxAmount = Math.Ceiling(stackAmount / 27);
                double doubleChestAmount = Math.Ceiling(stackAmount / 54);
                Console.WriteLine($"{itemAmount} is equal to: {stackAmount} stacks and {stackRemainder} items.");
                Console.WriteLine($"You would need {shulkerBoxAmount} shulker boxes or {doubleChestAmount} double chests to store all the items.\n");
            }
        }
    }
}
