using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Data_Layers.Data_Access_Layer.Interfaces
{
    interface ICoalition
    {
        List<Coalition> GetAllCoalitions();
        List<Coalition> GetCoalitionsFromEllection(int election_id);
        bool DeletePartyFromCoalition(int party_id, int coalition_id);
        bool AddPartyFromCoalition(int party_id, int coalition_id);
        int AddCoalition(Coalition coalition);
        bool EditCoalition(Coalition coalition);
        bool DeleteCoalition(int coalition_id);
    }
}
