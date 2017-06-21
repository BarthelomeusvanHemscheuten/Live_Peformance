using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Data_Layers;

namespace Live_Peformance
{
    public partial class CreateEllection : Form
    {
        public CreateEllection()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Ellection ellection = new Ellection(dtpBegin.Value, dtpEnd.Value, rbTrue.Checked, Convert.ToInt32(tbSeats.Text), tbKind.Text, tbName.Text);

        }
    }
}
