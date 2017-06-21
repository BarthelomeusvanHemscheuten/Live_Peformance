using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;

namespace Business_Data_Layers.Data_Access_Layer.Percistencies
{
    class ResultPercistency : IResult
    {
        public bool AddResult(Result result)
        {
            throw new NotImplementedException();
        }

        public bool ChangeResult(Result result)
        {
            throw new NotImplementedException();
        }

        public List<Result> GetAllResultsFromEllection()
        {
            throw new NotImplementedException();
        }

        public int SetResult(int ellection_id, Result result)
        {
            throw new NotImplementedException();
        }
    }
}
