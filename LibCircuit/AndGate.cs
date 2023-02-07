using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibInterface;

namespace LibCircuit
{
    class AndGate : ILogic
    {
        private readonly ILogic m_input1;
        private readonly ILogic m_input2;

        public AndGate(ILogic Input1, ILogic Input2)
        {
            m_input1 = Input1;
            m_input2 = Input2;
        }

        public bool Output => m_input1.Output & m_input2.Output;
    }
}
