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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void graphSelect_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable select_btn only when a selection is made in graphSelect_cbx
            select_btn.Enabled = true;
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            /***********************************************
             * onClick handler for select_btn.
             * 
             * Creates a new instance of ChartForm, passing 
             * the index of the selected dataset to its constructor 
             * before showing it and hiding this form.
             ***********************************************/
            ChartForm cf = new ChartForm(0, this);

            cf.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open link to data source
            System.Diagnostics.Process.Start("http://www.tylervigen.com/spurious-correlations");
        }
    }
}
