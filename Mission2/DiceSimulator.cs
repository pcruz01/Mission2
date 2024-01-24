using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceSimulator
    {
        private Random random = new Random();

        public int[] SimulateDiceRolls(int numberOfRolls)
        {
            int[] results = new int[11]; // Possible sums range from 2 to 12 for two six-sided dice

            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll1 = random.Next(1, 7); // Roll for the first die
                int roll2 = random.Next(1, 7); // Roll for the second die

                int sum = roll1 + roll2; // Calculate the sum of the two rolls
                results[sum - 2]++; // Increment the count for the corresponding sum
            }

            return results;
        }
    }
}