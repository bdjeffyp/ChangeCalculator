using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Accept user input.
            //TODO: Add comments to explain the code.
            //TODO: Guess and confirm when the user enters an amount as $ or cents.
            double change = 1.80;
            const int QUARTER = 25;
            const int DIME = 10;
            const int NICKEL = 5;
            const int PENNY = 1;
            int numQuarters = 0;
            int numDimes = 0;
            int numNickels = 0;
            int numPennies = 0;
            int changeAsInt = 0;

            changeAsInt = (int)(change * 100.0);

            numQuarters = changeAsInt / QUARTER;
            changeAsInt -= numQuarters * QUARTER;
            numDimes = changeAsInt / DIME;
            changeAsInt -= numDimes * DIME;
            numNickels = changeAsInt / NICKEL;
            changeAsInt -= numNickels * NICKEL;
            numPennies = changeAsInt / PENNY;

            Console.WriteLine("Your change is {0}", change);
            Console.WriteLine("You get {0} quarters, {1} dimes, {2} nickels, and {3} pennies.", numQuarters, numDimes, numNickels, numPennies);
        }
    }
}
