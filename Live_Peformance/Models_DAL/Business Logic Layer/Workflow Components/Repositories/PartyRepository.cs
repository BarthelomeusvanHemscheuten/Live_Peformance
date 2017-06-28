using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.Percistencies;

namespace Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories
{
    class PartyRepository
    {
        IParty context = new PartyPercistency();
        public List<Party> GetAllParties()
        {
            return context.GetAllParties();
        }
        public List<Party> GetPartiesFromEllection(int ellection_id)
        {
            return context.GetPartiesFromEllection(ellection_id);
        }
        public List<Party> GetPartiesFromCoalition(int coalition_id)
        {
            return context.GetPartiesFromCoalition(coalition_id);
        }
        public bool CreateParty(Party party, int ellection_id)
        {
            return context.AddParty(ellection_id, party);
        }
        public bool EditParty(Party party)
        {
            return context.EditParty(party);
        }
    }
}
