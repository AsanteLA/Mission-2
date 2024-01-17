using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission__2
{
    internal class Dice
    {
        public void DiceRoll(int NoOfRolls, int percent1)
        {

            //Creating Random instance 
            Random random = new Random();

            //Array for SumCounts 
            int[] SumCounts = new int[11];

            /*
            // Variables for dice count 
            int Sum2Count = 0;
            int Sum3Count = 0;
            int Sum4Count = 0;
            int Sum5Count = 0;
            int Sum6Count = 0;
            int Sum7Count = 0;
            int Sum8Count = 0;
            int Sum9Count = 0;
            int Sum10Count = 0;
            int Sum11Count = 0;
            int Sum12Count = 0;
            */


            for (int iRolls = 1; iRolls <= NoOfRolls; iRolls++) 
            {
                //Random number generators for both dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2;

                /*
                //incrementing the Sum Counts based on the value of the sum variable
                if (sum == 2) Sum2Count++;
                else if (sum == 3) Sum3Count++;
                else if (sum == 4) Sum4Count++;
                else if (sum == 5) Sum5Count++;
                else if (sum == 6) Sum6Count++;
                else if (sum == 7) Sum7Count++;
                else if (sum == 8) Sum8Count++;
                else if (sum == 9) Sum9Count++;
                else if (sum == 10) Sum10Count++;
                else if (sum == 11) Sum11Count++;
                else Sum12Count++;
                */

                if (sum >= 2 && sum <= 12) //making sure the sums are from 2 to 12
                    SumCounts[sum-2]++;
            }

            for (int i = 0; i < SumCounts.Length; i++)
            {
             
                int percent = ((SumCounts[i] * 100)/ NoOfRolls) / percent1;
                System.Console.WriteLine($"{i + 2}: {new string ('*', percent)}");
            }
            

        }
    }
}
