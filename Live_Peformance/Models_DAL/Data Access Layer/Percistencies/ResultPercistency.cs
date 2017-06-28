using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.DatabaseConnections;

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

        public List<Result> GetAllResultsFromEllection(int ellection_id)
        {
            string query = @"SELECT * FROM [Uitslag] WHERE [Verkiezing_ID] = @id";
            query = query.Replace("@id", ellection_id.ToString());
            List<Result> results = new List<Result>();
            foreach(object[] data in DatabaseConnection.Read(query))
            {
                Result result = new Result((string)data[1]);
                result.SetID((int)data[0]);
                results.Add(result);
            }
            return results;
        }

        public int SetResult(int ellection_id, Result result)
        {
            throw new NotImplementedException();
        }
    }
}
