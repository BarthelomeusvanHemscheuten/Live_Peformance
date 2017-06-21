using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Data_Layers.Data_Access_Layer.Interfaces
{
    interface IEllection
    {
        List<Ellection> GetAllEllections();
        int AddEllection(Ellection ellection);
        bool EditEllection(Ellection ellection);
        bool DeleteEllection(int ellection_id);

    }
}
