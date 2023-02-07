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

namespace WinCircuit
{
    public partial class WinCircuitForm : Form
    {
        public ILogic Circuit { get; set; }

        public WinCircuitForm()
        {
            InitializeComponent();
        }

        private void WinCircuitForm_Load(object sender, EventArgs e) => btnRun.Enabled = Circuit != null;

        // Function to get input from Windows UI
        public bool GetInput(int InputNo)
        {
            InputForm form = new InputForm(InputNo);
            return form.ShowDialog(this) == DialogResult.Yes;
        }

        private void btnRun_Click(object sender, EventArgs e) => lblOutput.Text = $"The output is {Circuit.Output}"; // Show circuit output
    }
}
