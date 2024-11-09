using System;

class GreenvilleRevenue
{
    static void Main()
    {

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");


        while (true)
        {

            Console.WriteLine("\nPlease Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");


            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                CalculateRevenue();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break; 
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option (1 or 2).");
            }
        }
    }

    static void CalculateRevenue()
    {

        Console.Write("Enter the number of contestants this year: ");
        int thisYearContestants = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of contestants last year: ");
        int lastYearContestants = int.Parse(Console.ReadLine());


        const int TicketPrice = 25;
        int expectedRevenue = thisYearContestants * TicketPrice;


        Console.WriteLine($"\nRevenue expected this year is: ${expectedRevenue}");


        if (thisYearContestants > 2*lastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else if (thisYearContestants < lastYearContestants)
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        else
        {
            Console.WriteLine("This year's competition has the same number of contestants as last year.");
        }
    }
}
