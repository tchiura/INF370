﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insight_Prototype_
{
    public partial class DeleteSupplierPage : Form
    {
        public DeleteSupplierPage()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this supplier?", "Delete", MessageBoxButtons.YesNo);
        }
    }
}
