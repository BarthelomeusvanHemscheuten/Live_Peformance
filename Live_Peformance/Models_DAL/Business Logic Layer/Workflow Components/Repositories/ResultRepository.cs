using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.Percistencies;
namespace Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories
{
    class ResultRepository
    {
        IResult context = new ResultPercistency();
        public List<Result> GetAllResulstsFromEllection(int ellection_id)
        {
            return context.GetAllResultsFromEllection(ellection_id);
        }
    }
}
