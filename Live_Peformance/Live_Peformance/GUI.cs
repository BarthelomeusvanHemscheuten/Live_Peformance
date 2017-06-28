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
            lbEllections.DataSource = facade.GetAllEllections();
            tabControl.SelectedIndex = 0;
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void lbEllections_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbEllections.SelectedItem != null)
            {
                Ellection ellection = (Ellection)lbEllections.SelectedItem;
                tbName.Text = ellection.Name;
                tbKind.Text = ellection.Kind;
                tbBegin.Text = ellection.BeginDate.ToString();
                tbEnd.Text = ellection.EndDate.ToString();
                tbSeats.Text = ellection.Seats.ToString();
                if (ellection.Running)
                {
                    tbRunning.Text = "Ja";
                }
                else if (!ellection.Running)
                {
                    tbRunning.Text = "Nee";
                }
                lbParties.DataSource = facade.GetPartiesFromEllection(ellection.ID);
                lbResults.DataSource = facade.GetAllResultsFromEllection(ellection.ID);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            CreateEllection popup = new CreateEllection(null);
            popup.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ellection ellection = (Ellection)lbEllections.SelectedItem;
            if (facade.DeleteEllection(ellection.ID))
            {
                MessageBox.Show("Verkiezing verwijderd");
            }
            else
            {
                MessageBox.Show("Er is iets fout gegaan");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbEllections.SelectedItem != null)
            {
                CreateEllection popup = new CreateEllection((Ellection)lbEllections.SelectedItem);
                popup.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbEllections.DataSource = facade.GetAllEllections();
            if (lbEllections.SelectedItem != null)
            {
                Ellection ellection = lbEllections.SelectedItem as Ellection;
                lbParties.DataSource = facade.GetPartiesFromEllection(ellection.ID);
                lbCoalition.DataSource = facade.GetAllResultsFromEllection(ellection.ID);
            }
        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            if (lbEllections.SelectedItem != null)
            {
                Ellection ellection = (Ellection)lbEllections.SelectedItem;
                CreateParty popup = new CreateParty(ellection.ID, null);
                popup.Show();
            }
        }

        private void lbParties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditParty_Click(object sender, EventArgs e)
        {
            if (lbParties.SelectedItem != null)
            {
                Party party = (Party)lbParties.SelectedItem;
                CreateParty popup = new CreateParty(0, party);
                popup.Show();
            }
        }

        private void btnAddCoalition_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedItem != null)
            {
                Result result = (Result)lbResults.SelectedItem;
                CreateCoaltion popup = new CreateCoaltion(result);
                popup.Show();
            }

        }

        private void btnCoalition_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedItem != null && lbEllections.SelectedItem != null)
            {
                Result result = (Result)lbResults.SelectedItem;
                lbCoalition.DataSource = facade.GetCoalitionFromResult(result.ID);
                Ellection ellection = (Ellection)lbEllections.SelectedItem;
                lbEllectionParties.DataSource = facade.GetPartiesFromEllection(ellection.ID);
            }
            tabControl.SelectedIndex = 1;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lbCoalition.Items.Count > 0)
            {
                lbCoalition.DataSource = null;
            }
            tabControl.SelectedIndex = 0;
        }

        private void lbEllectionParties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCoalition.SelectedItem != null)
            {
                Coalition coalition = (Coalition)lbCoalition.SelectedItem;
                lbCoalitionParties.DataSource = facade.GetPartiesFromCoalition(coalition.ID);
            }
        }

        private void btnAddtoCoalition_Click(object sender, EventArgs e)
        {
            if (lbEllectionParties.SelectedItem != null)
            {
                Party party = (Party)lbEllectionParties.SelectedItem;
                Coalition coalition = (Coalition)lbCoalition.SelectedItem;
                facade.AddPartytoCoalation(party, coalition);
                lbCoalitionParties.DataSource = facade.GetPartiesFromCoalition(coalition.ID);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
