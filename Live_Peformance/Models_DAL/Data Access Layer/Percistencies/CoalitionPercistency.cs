using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.DatabaseConnections;

namespace Business_Data_Layers.Data_Access_Layer.Percistencies
{
    class CoalitionPercistency : ICoalition
    {
        public int AddCoalition(Coalition coalition)
        {
            string query = @"INSERT INTO [Coalitie]([Premier], [Naam], [Uitslag_ID]) VALUES('@premier', '@naam', @id)";
            query = query.Replace("@premier", coalition.Premier)
                .Replace("@naam", coalition.Name)
                .Replace("@id", coalition.result.ID.ToString());
            return DatabaseConnection.Create(query);
        }

        public bool DeleteCoalition(int coalition_id)
        {
            string query = @"DELETE FROM [Coalitie] WHERE [ID] = @id";
            query = query.Replace("@id", coalition_id.ToString());
            return DatabaseConnection.Delete(query);
        }

        public bool EditCoalition(Coalition coalition)
        {
            string query = @"UPDATE [Coalitie] SET [Premier] = '@premier', [Naam] = '@naam', [Uitslag_ID] = @id";
            query = query.Replace("@premier", coalition.Premier)
                .Replace("@naam", coalition.Name)
                .Replace("@id", coalition.result.ID.ToString());
            return DatabaseConnection.Delete(query);
        }
        public bool DeletePartyFromCoalition(int party_id, int coalition_id)
        {
            string query = @"DELETE FROM [Partij_Coalitie] WHERE [Partij_ID] = @partyID AND [Coalitie_ID] = @coalitionID";
            query = query.Replace("@partyID", party_id.ToString())
                .Replace("@coalitionID", coalition_id.ToString());
            return DatabaseConnection.Delete(query);
        }
        public bool AddPartyFromCoalition(int party_id, int coalition_id)
        {
            string query = @"INSERT INTO [Partij_Coalitie] (Partij_ID, Coalitie_ID) VALUES (@partyID, @coalitionID)";
            query = query.Replace("@partyID", party_id.ToString())
                              .Replace("@coalitionID", coalition_id.ToString());
            return DatabaseConnection.Update(query);
        }


        public List<Coalition> GetCoalitionsFromResult(int result_id)
        {
            string query = @"SELECT * FROM [Coalitie] WHERE [Uitslag_ID] = @id";
            query = query.Replace("@id", result_id.ToString());
            List<Coalition> coalitions = new List<Coalition>();
            foreach (object[] data in DatabaseConnection.Read(query))
            {
                Coalition coalition = new Coalition((string)data[1], (string)data[2]);
                coalition.SetID((int)data[0]);
                coalitions.Add(coalition);
            }
            return coalitions;
        }
    }
}
