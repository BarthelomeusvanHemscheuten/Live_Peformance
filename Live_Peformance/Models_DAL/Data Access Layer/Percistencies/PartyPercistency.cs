using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Data_Access_Layer.Interfaces;
using Business_Data_Layers.Data_Access_Layer.DatabaseConnections;

namespace Business_Data_Layers.Data_Access_Layer.Percistencies
{
    class PartyPercistency : IParty
    {
        public bool AddParty(int ellection_id, Party party)
        {
            string query = @"INSERT INTO [Partij](Naam, Lijsttrekker) VALUES('@naam', '@lijsttrekker')";
            query = query.Replace("@naam", party.Name)
                .Replace("@lijsttrekker", party.Represenitive);
            int party_id = DatabaseConnection.Create(query);
            if(party_id != -1)
            {
                string query_ellection = @"INSERT INTO [Partij_Verkiezing](Verkiezing_ID, Partij_ID, Stemmen) VALUES (@ellectionID, @partyID, @votes)";
                query_ellection = query_ellection.Replace("@ellectionID", ellection_id.ToString())
                    .Replace("@partyID", party_id.ToString())
                    .Replace("@votes", party.Votes.ToString());
                return DatabaseConnection.Update(query_ellection);

            }
            return false;
            
        }

        public bool EditParty(Party party)
        {
            string query = @"UPDATE [Partij] SET [Naam] = '@name', [Lijsttrekker] = '@representitive'";
            query = query.Replace("@name", party.Name)
                .Replace("@representitive", party.Represenitive);
            if(party.Votes != 0)
            {
                string query_2 = @"UPDATE [Partij_Verkiezing] SET [Stemmen] = @votes WHERE [Partij_ID] = @id";
                query_2 = query_2.Replace("@votes", party.Votes.ToString())
                    .Replace("@id", party.ID.ToString());
                return DatabaseConnection.Update(query);
            }
            return DatabaseConnection.Update(query);
        }

        public List<Party> GetPartiesFromCoalition(int coaltion_id)
        {
            List<Party> parties = new List<Party>();
            foreach(object[] data in DatabaseConnection.StoredProcedure("GetParty", "@coalitionID", "@ellectionID", coaltion_id, 0))
            {
                Party party = new Party((string)data[1], (string)data[2]);
                party.SetID((int)data[0]);
                parties.Add(party);
            }
            return parties;
        }

        public List<Party> GetPartiesFromEllection(int ellection_id)
        {
            List<Party> parties = new List<Party>();
            foreach (object[] data in DatabaseConnection.StoredProcedure("GetParty", "@coalitionID", "@ellectionID", 0, ellection_id))
            {
                Party party = new Party((string)data[1], (string)data[2]);
                party.SetID((int)data[0]);
                party.SetVotes((int)data[3]);
                parties.Add(party);
            }
            return parties;
        }
        public List<Party> GetAllParties()
        {
            string query = @"SELECT * FROM [Partij]";
            List<Party> parties = new List<Party>();
            foreach(object[] data in DatabaseConnection.Read(query))
            {
                Party party = new Party((string)data[1], (string)data[2]);
                party.SetID((int)data[0]);
                parties.Add(party);
            }
            return parties;
        }
    }
}
