namespace Home_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double danielleTotal = 0, edwardTotal = 0, francisTotal = 0;

            //user input variables
            char salesRep;
            double saleAmount;

            // prompting for salesRep initials until the user enters 'Z'
            do
            {
                Console.Write("Enter a salesRep initial of D, E or F, then select Z to end input: ");
                salesRep = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine(); 

                // Checking if user input is for valid salesRep
                if (salesRep == 'D' || salesRep == 'E' || salesRep == 'F')
                {
                    Console.Write("Enter a sale amount: ");
                   if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount > 0)
                   {
                        // Adding the sales to the correct salesRep's total
                        if (salesRep == 'D')
                            danielleTotal += saleAmount;
                        else if (salesRep == 'E')
                            edwardTotal += saleAmount;
                        else if (salesRep == 'F')
                            francisTotal += saleAmount;
                   }
                   else
                   {
                        Console.WriteLine("Invalid numberm please enter a valid number and try again");
                   }
                }
                else if (salesRep != 'Z')
                {
                    Console.WriteLine("Error, invalid salesperson selected, please try again");
                }

            } while (salesRep != 'Z');

           // totals printed
             Console.WriteLine($"\nDanielle's total: {danielleTotal:C}");

             Console.WriteLine($"Edward's total: {edwardTotal:C}");

             Console.WriteLine($"Francis' total: {francisTotal:C}");

             Console.WriteLine($"Grand total: {danielleTotal + edwardTotal + francisTotal:C}");

            // if statement showing the sales rep with highest sales total
           if (danielleTotal >= edwardTotal && danielleTotal >= francisTotal)
                Console.WriteLine("Highest sale: D");

            else if (edwardTotal >= danielleTotal && edwardTotal >= francisTotal)
                Console.WriteLine("Highest sale: E");

           else
                Console.WriteLine("Highest sale: F");
        }
    }
    
}

