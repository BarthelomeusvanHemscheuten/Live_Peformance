using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories;

public class Coalition
{
    CoalitionRepository repo = new CoalitionRepository();
    PartyRepository partyrepo = new PartyRepository();
    //Properties
    List<Party> parites;
    public int ID { get; set; }

    public string Name { get; set; }

    public string Premier { get; set; }

    public List<Party> parties
    {
        get
        {
            parties = partyrepo.GetPartiesFromCoalition(ID);
            return parties;
        }
        set
        {
            parties = value;
        }
    }
    public Result result { get; set; }

    public int Seats { get; set; }

    //Constructors
    public Coalition(string name)
    {
        Name = name;
    }
    public Coalition(string name, string premier)
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

    public void CalculatePremier()
    {
        Party party = parties.OrderByDescending(p => p.Votes).FirstOrDefault();
        Premier = party.Represenitive;
    }

    public void CalculateSeats(int max_seats)
    {
        int seats = 0;
        int all_votes = 0;
        foreach(Party party in parties)
        {
            all_votes += party.Votes;
        }
        foreach(Party party in parties)
        {
            seats = (all_votes / party.Votes) * 150;
        }
        Seats = seats;
    }

}

