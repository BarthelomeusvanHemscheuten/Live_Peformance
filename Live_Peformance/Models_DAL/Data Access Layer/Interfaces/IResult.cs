using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Data_Layers.Data_Access_Layer.Interfaces
{
    interface IResult
    {
        List<Result> GetAllResultsFromEllection(int ellection_id);
        int SetResult(int ellection_id, Result result);
        bool AddResult(Result result);
        bool ChangeResult(Result result);
    }
}
