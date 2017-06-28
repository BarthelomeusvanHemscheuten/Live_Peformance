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
    public partial class CreateEllection : Form
    {
        MainFacade facade = new MainFacade();
        Ellection ellection = null;
        public CreateEllection(Ellection ellection)
        {
            InitializeComponent();
            btnCreate.Visible = false;
            btnEdit.Visible = false;
            if (ellection == null)
            {
                btnCreate.Visible = true;
            }
            else if (ellection != null)
            {
                this.ellection = ellection;
                tbName.Text = ellection.Name;
                tbKind.Text = ellection.Kind;
                tbSeats.Text = ellection.Seats.ToString();
                dtpBegin.Value = ellection.BeginDate;
                dtpEnd.Value = ellection.EndDate;
                if(ellection.Running)
                {
                    rbTrue.Checked = true;
                }
                else if(!ellection.Running)
                {
                    rbFalse.Checked = true;
                }
                btnEdit.Visible = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Ellection ellection = new Ellection(dtpBegin.Value, dtpEnd.Value, rbTrue.Checked, Convert.ToInt32(tbSeats.Text), tbKind.Text, tbName.Text);
                if (facade.CreateEllection(ellection))
                {
                    MessageBox.Show("Verkiezing aangemaakt");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Er is iets verkeerd gegaan, probeer opnieuw");
                }
            }
            catch
            {
                MessageBox.Show("Vull valide gegevens in");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Ellection ellection = new Ellection(dtpBegin.Value, dtpEnd.Value, rbTrue.Checked, Convert.ToInt32(tbSeats.Text), tbKind.Text, tbName.Text);
                ellection.SetID(this.ellection.ID);
                if (facade.EditEllection(ellection))
                {
                    MessageBox.Show("Verkiezing bijgewerkt");
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
