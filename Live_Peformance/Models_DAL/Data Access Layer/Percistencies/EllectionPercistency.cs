using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.DatabaseConnections;

namespace Business_Data_Layers.Data_Access_Layer.Percistencies
{
    class EllectionPercistency : IEllection
    {
        public int AddEllection(Ellection ellection)
        {
            throw new NotImplementedException();
        }

        public bool AddResult(Result result)
        {
            throw new NotImplementedException();
        }

        public bool ChangeResult(Result result)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEllection(int ellection_id)
        {
            throw new NotImplementedException();
        }

        public bool EditEllection(Ellection ellection)
        {
            throw new NotImplementedException();
        }

        public List<Ellection> GetAllEllections()
        {
            string query = @"SELECT * FROM [Verkiezing]";
            List<Ellection> ellections = new List<Ellection>();
            foreach(object[] data in DatabaseConnection.Read(query) )
            {
                Ellection ellection = new Ellection((DateTime)data[1], (DateTime)data[2], (bool)data[3], (int)data[4], (string)data[5], (string)data[6]);
                ellection.SetID((int)data[0]);
                ellections.Add(ellection);
            }
            return ellections;
        }

        public List<Result> GetAllResultsFromEllection()
        {
            throw new NotImplementedException();
        }

        public bool SetResult(int ellection_id, Result result)
        {
            throw new NotImplementedException();
        }
    }
}
