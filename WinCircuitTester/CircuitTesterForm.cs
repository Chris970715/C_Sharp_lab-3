using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibInterface;

namespace WinCircuitTester
{
    public partial class CircuitTesterForm : Form
    {
        private int m_inputCount = 0;
        private int m_input;
        private Func<int, bool> m_currentInput;

        public ILogic Circuit { get; set; }

        public CircuitTesterForm()
        {
            InitializeComponent();
        }

        private void CircuitTesterForm_Load(object sender, EventArgs e) => btnStartTest.Enabled = Circuit != null;

        private bool InputCount(int InputNo)
        {
            m_inputCount = InputNo > m_inputCount ? InputNo : m_inputCount; // Keep the maximum input number
            return false;
        }

        public bool GetInput(int InputNo) => m_currentInput(InputNo);

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            m_currentInput = InputCount; // Use this input function to count how many inputs there are
            _ = Circuit.Output; // Don't need output result, so use discard (_)
            lstOutputs.Items.Clear();
            m_currentInput = GetTestInput; // Use this input function to generate input based on input number
            for(m_input = 0; m_input < (1 << m_inputCount); m_input++) // Iterate through all possible input combinations
                lstOutputs.Items.Add($"{Convert.ToString(m_input, 2).PadLeft(m_inputCount, '0')}: {Circuit.Output}"); // Show inputs in binary (base 2) and corresponding output
        }

        private bool GetTestInput(int InputNo) => (m_input & (1 << (InputNo - 1))) != 0; // Generate true for input of 1, false for input of 0 (input in bit position)

        private void lstOutputs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
