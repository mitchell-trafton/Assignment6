using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class ChartForm : Form
    {
        public ChartForm(int ChartNum)
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
