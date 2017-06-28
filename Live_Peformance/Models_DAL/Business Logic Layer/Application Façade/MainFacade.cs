using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories;

namespace Business_Data_Layers.Business_Logic_Layer.Application_Façade
{
    public class MainFacade
    {
        EllectionRepository ellectionrepo = new EllectionRepository();
        PartyRepository partyrepo = new PartyRepository();
        ResultRepository resultrepo = new ResultRepository();
        CoalitionRepository coalitionrepo = new CoalitionRepository();
        public List<Ellection> GetAllEllections()
        {
            return ellectionrepo.GetAllEllections();
        }
        public bool CreateEllection(Ellection ellection)
        {
            return ellectionrepo.CreateEllection(ellection) != -1;
        }
        public bool EditEllection(Ellection ellection)
        {
            return ellectionrepo.UpdateEllection(ellection);
        }
        public bool DeleteEllection(int ellection_id)
        {
            return ellectionrepo.DeleteEllectoin(ellection_id);
        }
        public List<Party> GetAllParties()
        {
            return partyrepo.GetAllParties();
        }
        public List<Party> GetPartiesFromEllection(int ellection_id)
        {
            return partyrepo.GetPartiesFromEllection(ellection_id);
        }
        public bool CreateParty(Party party, int election_id)
        {
            return partyrepo.CreateParty(party, election_id);
        }
        public bool EditParty(Party party)
        {
            return partyrepo.EditParty(party);
        }
        public List<Result> GetAllResultsFromEllection(int ellection_id)
        {
            return resultrepo.GetAllResulstsFromEllection(ellection_id);
        }
        public List<Coalition> GetCoalitionFromResult(int result_id)
        {
            return coalitionrepo.GetCoalitionFromResult(result_id);
        }
        public bool CreateCoalition(Coalition coalition)
        {
            return coalitionrepo.CreateCoalition(coalition);
        }
        public List<Party> GetPartiesFromCoalition(int coalition_id)
        {
            return partyrepo.GetPartiesFromCoalition(coalition_id);
        }
        public bool AddPartytoCoalation(Party party, Coalition coalition)
        {
            return coalitionrepo.AddClasstoCoalition(coalition, party);
        }
    }
}
