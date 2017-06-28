using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories;
public class Party
{
    PartyRepository repo = new PartyRepository();
    public int ID { get; set; }

    public int Votes { get; set; }

    public int Seats { get; set; }
    public string Name { get; set; }

    public string Represenitive { get; set; }

    public Ellection ellection { get; set; }

    public Party(string name, string representitive)
    {
        Name = name;
        Represenitive = representitive;
    }
    public bool EditParty(int name, string representitive, int votes)
    {
        throw new System.NotImplementedException();
    }
    public void SetID(int id)
    {
        ID = id;
    }
    public void SetVotes(int votes)
    {
        Votes = votes;
    }
    public void SetSeats(int seats)
    {

    }
    public override string ToString()
    {
        return Name + "________" + Represenitive + "______" + Votes.ToString();
    }

}

