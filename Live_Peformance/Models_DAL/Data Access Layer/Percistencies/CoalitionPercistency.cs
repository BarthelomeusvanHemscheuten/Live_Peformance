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

        public List<Coalition> GetAllCoalitions()
        {
            string query = @"SELECT c.ID, c.Premier, c.Naam, v.ID, v.BeginDatum, v.EindDatum, v.Lopend, v.Zetels, v.Soort, v.Naam, u.ID, u.Naam FROM [Coalitie] c 
                             INNER JOIN [Uitslag] u ON c.Uitslag_ID = u.ID
							 INNER JOIN [Verkiezing] v ON u.Verkiezing_ID = v.ID";
            List<Coalition> coalitions = new List<Coalition>();
            foreach(object[] data in DatabaseConnection.Read(query))
            {
                Coalition coalition = new Coalition((string)data[1], (string)data[2]);
                coalition.SetID((int)data[0]);
                Result result = new Result((string)data[11]);
                result.SetID((int)data[10]);
                Ellection ellection = new Ellection((DateTime)data[4], (DateTime)data[5], (bool)data[6], (int)data[7], (string)data[8], (string)data[9]);
                ellection.SetID((int)data[3]);
                List<Party> parties = new List<Party>();
                foreach(object[] p_data in DatabaseConnection.StoredProcedure("GetParties", "@coalitionID", "@ellectionID", (int)data[0], 0))
                {
                    Party party = new Party((string)data[1], (string)data[2]);
                    party.SetID((int)data[0]);
                    parties.Add(party);
                }
                coalition.SetParties(parties);
                result.SetEllection(ellection);
                coalition.SetResult(result);
            }
            return coalitions;
        }

        public List<Coalition> GetCoalitionsFromEllection(int ellection_id)
        {
            string query = @"SELECT c.ID, c.Premier, c.Naam, v.ID, v.BeginDatum, v.EindDatum, v.Lopend, v.Zetels, v.Soort, v.Naam, u.ID, u.Naam FROM [Coalitie] c 
                             INNER JOIN [Uitslag] u ON c.Uitslag_ID = u.ID
							 INNER JOIN [Verkiezing] v ON u.Verkiezing_ID = v.ID where v.ID = @id";
            query = query.Replace("@id", ellection_id.ToString());
            List<Coalition> coalitions = new List<Coalition>();
            foreach (object[] data in DatabaseConnection.Read(query))
            {
                Coalition coalition = new Coalition((string)data[1], (string)data[2]);
                coalition.SetID((int)data[0]);
                Result result = new Result((string)data[11]);
                result.SetID((int)data[10]);
                Ellection ellection = new Ellection((DateTime)data[4], (DateTime)data[5], (bool)data[6], (int)data[7], (string)data[8], (string)data[9]);
                ellection.SetID((int)data[3]);

                result.SetEllection(ellection);
                coalition.SetResult(result);
            }
            return coalitions;
        }
    }
}
