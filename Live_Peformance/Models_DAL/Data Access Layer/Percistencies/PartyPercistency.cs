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
        public int AddParty(int ellection_id, Party party)
        {
            string query = @"INSERT INTO [Partij](Naam, Lijsttrekker) VALUES('@naam', '@lijsttrekker')";
            query = query.Replace("@naam", party.Name)
                .Replace("@lijsttrekker", party.Represenitive);
            return DatabaseConnection.Create(query);
            
        }

        public bool EditParty(Party party)
        {
            string query = @"UPDATE [Partij] SET [Naam] = '@name', [Lijsttrekker] = '@representitive'";
            query = query.Replace("@name", party.Name)
                .Replace("@representitive", party.Represenitive);
            return DatabaseConnection.Update(query);
        }

        public List<Party> GetPartiesFromCoalition(int coaltion_id)
        {
            List<Party> parties = new List<Party>();
            foreach(object[] data in DatabaseConnection.StoredProcedure("GetParties", "@coalitionID", "@ellectionID", coaltion_id, 0))
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
            foreach (object[] data in DatabaseConnection.StoredProcedure("GetParties", "@coalitionID", "@ellectionID", 0, ellection_id))
            {
                Party party = new Party((string)data[1], (string)data[2]);
                party.SetID((int)data[0]);
                parties.Add(party);
            }
            return parties;
        }
    }
}
