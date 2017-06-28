using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.Percistencies;

namespace Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories
{
    class CoalitionRepository
    {
       ICoalition context = new CoalitionPercistency();
        public List<Coalition> GetCoalitionFromResult(int result_id)
        {
            return context.GetCoalitionsFromResult(result_id);
        }
        public bool CreateCoalition(Coalition coalition)
        {
            return context.AddCoalition(coalition) != -1;
        }
        public bool AddClasstoCoalition(Coalition coaltion, Party party)
        {
            return context.AddPartyFromCoalition(party.ID, coaltion.ID);
        }
    }
}
