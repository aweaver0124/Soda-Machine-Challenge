using System;

namespace SodaMachineChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinkMachine = new SodaMachine();

            while (!drinkMachine.checkTotal())
            {
                Console.WriteLine("The cost of a drink is $1.75. Please enter coins or a dollar bill (5, 10, 25, 100)");
                drinkMachine.InsertCoin(Convert.ToInt32(Console.ReadLine()));
            }

            drinkMachine.ShowDrinkSelection();

            Console.ReadLine();
        }
    }
}