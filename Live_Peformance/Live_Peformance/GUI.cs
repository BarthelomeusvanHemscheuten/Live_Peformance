using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Data_Layers;
using Business_Data_Layers.Business_Logic_Layer.Application_Façade;

namespace Live_Peformance
{
    public partial class GUI : Form
    {
        MainFacade facade = new MainFacade();
        public GUI()
        {
            InitializeComponent();
        }

        private void lbEllections_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(lbEllections.Items != null && tabControl.SelectedTab == tabEllection)
            {
                Ellection ellection = (Ellection)lbEllections.SelectedItem;
                tbName.Text = ellection.Name;
                tbKind.Text = ellection.Kind;
                tbStartDate.Text = ellection.BeginDate.ToString();
                tbEndDate.Text = ellection.EndDate.ToString();
                tbSeats.Text = ellection.Seats.ToString();
                if(ellection.Running)
                {
                    tbRunning.Text = "Ja";
                }
                else if(!ellection.Running)
                {
                    tbRunning.Text = "Nee";
                }             
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(lbEllections.SelectedItem != null)
            {

            }
        }

        private void lbEllections_Click(object sender, EventArgs e)
        {
            lbEllections.DataSource = facade.GetAllEllections();
        }
    }
}
