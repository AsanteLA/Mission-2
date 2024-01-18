using Mission__2;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Dice dc = new Dice(); //Creating a new dice entity

        System.Console.WriteLine("Welcome to the Dice Simulator!\n");

        int NoOfRolls = 0; //Creating a Number of Rolls integer

        //Asking the user the question
        System.Console.WriteLine("How many dice rolls would you like to simulate?\n");
        NoOfRolls = int.Parse(System.Console.ReadLine()); //Accessing the answer to the question which becomes the NoOfRolls variable

        int percent1 = (int) ((double)(100 / 100)); //1 Percent value 

        //Outputs
        System.Console.WriteLine("\nDICE ROLLING SIMULATION REULTS:");
        System.Console.WriteLine($"Each '*' represents {percent1}% of the total number of rolls");
        System.Console.WriteLine($"Total number of rolls = {NoOfRolls}\n");

        dc.DiceRoll(NoOfRolls, percent1);//passing variables to the Diceroll Class
    }
}