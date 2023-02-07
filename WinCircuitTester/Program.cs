using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibInterface;
using LibCircuit;

namespace WinCircuitTester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CircuitTesterForm form = new CircuitTesterForm();
            IInputFactory inputFactory = new InputFactory(form.GetInput); // Specify Windows callback for Input
            IGateFactory gateFactory = new GateFactory();
            ILogic circuit = new Circuit2(inputFactory, gateFactory); // dependency injection
            form.Circuit = circuit; // dependency injection
            Application.Run(form);
        }
    }
}
