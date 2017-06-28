using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Data_Layers.Business_Logic_Layer.Application_Façade;

namespace Live_Peformance
{
    public partial class CreateParty : Form
    {
        MainFacade facade = new MainFacade();
        int ellection_id = 0;
        Party party = null;
        public CreateParty(int ellection_id, Party party)
        {
            InitializeComponent();
            this.ellection_id = ellection_id;
            this.party = party;
            if (this.party == null)
            {
                btnAdd.Visible = true;
                btnEdit.Visible = false;
            }
            else if (this.ellection_id == 0)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = true;
                tbName.Text = party.Name;
                tbRepresentitive.Text = party.Represenitive;
                tbVotes.Text = party.Votes.ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Party party = new Party(tbName.Text, tbRepresentitive.Text);

                party.SetVotes(Convert.ToInt32(tbVotes.Text));

                if (facade.CreateParty(party, ellection_id))
                {
                    MessageBox.Show("Party gemaakt");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan, probeer opnieuw");
                }
            }
            catch
            {
                MessageBox.Show("Vul valide gegevens in");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Party party = new Party(tbName.Text, tbRepresentitive.Text);
                party.SetID(this.party.ID);
                party.SetVotes(Convert.ToInt32(tbVotes.Text));
                if (facade.EditParty(party))
                {
                    MessageBox.Show("Partij aangepast");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan, probeer opnieuw");
                }
            }
            catch
            {
                MessageBox.Show("Vul valide gegevens in");
            }
        }
    }
}
