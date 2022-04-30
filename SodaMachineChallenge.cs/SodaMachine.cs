namespace SodaMachineChallenge
{
    class SodaMachine
    {
      
        const int CostOfDrink = 175;
        public int CurrentBalanace { get; set; }

        public SodaMachine()
        {
            CurrentBalanace = 0;
        }

        public void InsertCoin(int coin)
        {
              // Valid coin entries are 5, 10, 25, 100 translating to nickels, dimes, quarters, and dollars
              switch (coin)
              {
                case (5):
                    CurrentBalance += 5;
                    break;
                case (10):
                    CurrentBalance += 10;
                    break;
                case (25):
                    CurrentBalance += 25;
                    break;
                case (100):
                    CurrentBalance += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
              }
        }

        public bool checkTotal()
        {
            if (CurrentBalanace >= CostOfDrink)
                return true;
            else
                return false;
        }

        public void ShowDrinkSelection()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Please Select A Beverage:");
            Console.WriteLine();
            Console.WriteLine("* W - Water             *");
            Console.WriteLine("* C - Coke              *");
            Console.WriteLine("* D - Diet Coke         *");
            Console.WriteLine("* G - Gatorade          *");
            Console.WriteLine("* O - Orange Fanta      *");
            Console.WriteLine("*************************");
            MakeSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void MakeSelection(char selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch(selection)
                {
                    case 'W':
                        Console.WriteLine("You have selected Water. Thank you for your purchase!");
                        selectionOK = true;
                        GiveChange();
                        break;
                    case 'C':
                        Console.WriteLine("You have selected Coke. Thank you for your purchase!");
                        selectionOK = true;
                        GiveChange();
                        break;
                     case 'D':
                        Console.WriteLine("You have selected Diet Coke. Thank you for your purchase!");
                        selectionOK = true;
                        GiveChange();
                        break;
                     case 'G':
                        Console.WriteLine("You have selected Gatorade. This product is currently sold out. Please make another selection.");
                        selectionOK = false;
                        break;
                     case 'O':
                        Console.WriteLine("You have selected Orange Fanta. Thank you for your purchase!");
                        selectionOK = true;
                        GiveChange();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please try again: ");
                        selection = Conert.ToChar(Console.ReadLine().ToUpper());
                        selectionOK = false;
                        break;
                }
            }
        }

        private void GiveChange()
        {
            if (CurrentBalanace > CostOfDrink)
                Console.WriteLine("Your change is {0:C}", CurrentBalanace - CostOfDrink);
        }
    }
}