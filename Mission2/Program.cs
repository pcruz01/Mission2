using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Connecting classes
        DiceSimulator diceSimulator = new DiceSimulator();

        // Variables
        string rollsInput;
        int numberOfRolls;

        // Program
        Console.WriteLine("Welcome to the dice rolling simulator ;)\n\n" +
            "How many dice rolls would you like to simulate?");

        rollsInput = Console.ReadLine();

        if (int.TryParse(rollsInput, out numberOfRolls) && numberOfRolls > 0)
        {
            int[] simulationResults = diceSimulator.SimulateDiceRolls(numberOfRolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
                "Each \"*\" represents 1% of the total number of rolls.\n" +
                "Total number of rolls = " + numberOfRolls + "\n");

            // Display the results
            for (int i = 0; i < simulationResults.Length; i++)
            {
                Console.WriteLine($"{i + 2}: {new string('*', simulationResults[i])}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the number of rolls.");
        }
    }
}