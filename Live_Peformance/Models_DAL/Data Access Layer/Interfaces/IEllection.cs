using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Data_Layers.Data_Access_Layer.Interfaces
{
    interface IEllection
    {
        //Ellection
        List<Ellection> GetAllEllections();
        bool AddEllection(Ellection ellection);
        bool EditEllection(Ellection ellection);
        bool DeleteEllection(int ellection_id);
        //Party
        List<Party> GetPartiesFromEllection();
        List<Party> GetPartiesFromCoalition();
        bool AddParty(int ellection_id, Party party);
        bool EditParty(Party party);
        //Coalition
        List<Coalition> GetAllCoalitions();
        List<Coalition> GetCoalitionsFromEllecTion();
        bool AddCoalition(Coalition coalition);
        bool EditCoalition(Coalition coalition);
        bool DeleteCoalition(int coalition_id);
        //Result
        List<Result> GetAllResultsFromEllection();
        bool SetResult(int ellection_id, Result result);
        bool AddResult(Result result);
        bool ChangeResult(Result result);
    }
}
