using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Data_Layers.Data_Access_Layer.Interfaces
{
    interface IParty
    {
        List<Party> GetPartiesFromEllection(int election_id);
        List<Party> GetPartiesFromCoalition(int coaltion_id);
        List<Party> GetAllParties();
        bool AddParty(int ellection_id, Party party);
        bool EditParty(Party party);
    }
}
