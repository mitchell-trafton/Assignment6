﻿using System;
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
            select_btn.Enabled = true;
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            ChartForm cf = new ChartForm(0);

            cf.Show();
            this.Hide();
        }
    }
}
