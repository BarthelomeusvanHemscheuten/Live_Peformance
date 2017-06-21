using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories;

public class Coalition
{
    CoalitionRepository repo = new CoalitionRepository();

    //Properties
    public int ID { get; set; }

    public string Name { get; set; }

    public string Premier { get; set; }

    public List<Party> parties { get; set; }
    public Result result { get; set; }

    public int Seats { get; set; }

    //Constructors
    public Coalition(string premier, string name)
    {
        Name = name;
        Premier = premier;
    }

    //Methods

    public bool EditCoalition(string name, string premier)
    {
        throw new System.NotImplementedException();
    }

    public void SetID(int id)
    {
        ID = id;
    }
    public void SetResult(Result result)
    {
        this.result = result;
    }


    public void SetParties(List<Party> Parties)
    {
        parties = Parties;
    }

    public string CalculatePremier()
    {
        throw new System.NotImplementedException();
    }

    public int CalculateSeats()
    {
        throw new System.NotImplementedException();
    }

}

