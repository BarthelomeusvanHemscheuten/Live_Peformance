using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Data_Layers.Business_Logic_Layer.Workflow_Components.Repositories;

public class Ellection
{
    EllectionRepository repo = new EllectionRepository();
    //Properties
    public DateTime BeginDate { get; set; }

    public DateTime EndDate { get; set; }

    public int ID { get; set; }

    public bool Running { get; set; }

    public int Seats { get; set; }

    public string Kind { get; set; }

    public string Name { get; set; }

    //Constructors
    public Ellection(DateTime beginDatum, DateTime endDate, bool running, int seats, string kind, string name)
    {
        BeginDate = BeginDate;
        EndDate = endDate;
        Running = running;
        Seats = seats;
        Kind = kind;
        Name = name;

    }

    //Methods

    public bool EditEllection(DateTime BeginDate, DateTime EndDate, bool Going, string Kind, string Name, int Seats)
    {
        throw new System.NotImplementedException();
    }

    public void SetID(int id)
    {
        ID = id;
    }

    public bool DeleteParty(Party Party)
    {
        throw new System.NotImplementedException();
    }

    public bool AddParty(Party Party)
    {
        throw new System.NotImplementedException();
    }

    public bool AddResults(Result Result)
    {
        throw new System.NotImplementedException();
    }

    public bool ChangeResult(Result Result)
    {
        throw new System.NotImplementedException();
    }

    public bool SetResult(Result Result)
    {
        throw new System.NotImplementedException();
    }

}

