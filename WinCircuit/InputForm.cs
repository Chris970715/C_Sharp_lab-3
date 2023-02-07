using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCircuit
{
    // Form to get input from Windows UI
    public partial class InputForm : Form
    {
        private readonly int m_inputNo;

        public InputForm(int InputNo)
        {
            InitializeComponent();
            m_inputNo = InputNo;
        }

        private void InputForm_Load(object sender, EventArgs e) => lblInput.Text = $"Value for Input #{m_inputNo}";
    }
}
