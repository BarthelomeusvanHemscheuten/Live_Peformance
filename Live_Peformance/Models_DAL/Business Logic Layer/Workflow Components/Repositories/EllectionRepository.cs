using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.Percistencies;

namespace Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories
{
    public class EllectionRepository
    {
        IEllection context = new EllectionPercistency();
        public List<Ellection> GetAllEllections()
        {
            return context.GetAllEllections();
        }
        public int CreateEllection(Ellection ellection)
        {
            return context.AddEllection(ellection);
        }
        public bool UpdateEllection(Ellection ellection)
        {
            return context.EditEllection(ellection);
        }
        public bool DeleteEllectoin(int ellection_id)
        {
            return context.DeleteEllection(ellection_id);
        }

    }
}
