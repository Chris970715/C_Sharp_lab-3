using LibInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCircuit;

namespace ConCircuit
{
    class Program
    {
        static void Main(string[] args)
        {
            ConCircuit circuitApp = new ConCircuit();
            IInputFactory inputFactory = new InputFactory(circuitApp.GetInput); // Specify Console callback for Input
            IGateFactory gateFactory = new GateFactory();
            ILogic circuit = new Circuit2(inputFactory, gateFactory); // dependency injection
            new ConCircuit().Run(circuit); // dependency injection
        }
    }
}
