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


        if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("It is true that this year's competition is bigger than last year's."); //what a weird way to say that
        }
        else if (thisYearContestants < lastYearContestants)
        {
            Console.WriteLine("This year's competition has fewer contestants than last year.");
        }
        else
        {
            Console.WriteLine("This year's competition has the same number of contestants as last year.");
        }
    }
}
