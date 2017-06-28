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
    public partial class CreateCoaltion : Form
    {
        Result result = null;
        MainFacade facade = new MainFacade();
        public CreateCoaltion(Result result)
        {
            this.result = result;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Coalition coalition = new Coalition(tbNaam.Text);
                coalition.SetResult(result);
                if (facade.CreateCoalition(coalition))
                {
                    MessageBox.Show("Coalitie gemaakt");
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
