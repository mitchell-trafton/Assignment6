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
        Form ParentForm;//refrence to form that called/created this form, used for returning when this one closes

        public ChartForm(int ChartNum, Form CallingForm)
        {
            InitializeComponent();

            ParentForm = CallingForm;
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Show();   
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
