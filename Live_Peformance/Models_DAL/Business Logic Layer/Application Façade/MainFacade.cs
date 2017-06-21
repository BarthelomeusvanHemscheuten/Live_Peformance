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
        public List<Ellection> GetAllEllections()
        {
            return ellectionrepo.GetAllEllections();
        }
    }
}
