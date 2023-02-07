using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibInterface;

namespace ConCircuit
{
    public class ConCircuit
    {
        public void Run(ILogic Circuit)
        {
            Console.WriteLine($"The output is {Circuit.Output}"); // Show the circuit output
            Console.ReadKey();
        }

        // Function to get input from the Console UI
        public bool GetInput(int InputNo)
        {
            Console.WriteLine($"What is the value for input #{InputNo}?");
            Console.WriteLine("T) True");
            Console.WriteLine("F) False");
            Console.WriteLine("Please enter your selection: ");
            string input = Console.ReadLine();
            while (0 == input.Length || "TtFf".IndexOf(input) < 0)
            {
                Console.WriteLine("Not a valid input.  Please enter your selection: ");
                input = Console.ReadLine();
            }
            return "Tt".IndexOf(input) >= 0;
        }
    }
}
