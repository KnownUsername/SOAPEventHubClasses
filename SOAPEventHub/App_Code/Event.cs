using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

//[DataContract]
public enum EventStatus
{
    open,
    closed,
    full,
    expired,
    cancelled
}

//[DataContract]
public class Event
{
    int id;
    string name;
    DateTime startDate;
    DateTime endDate;
    string local;
    string description;
    int slots;
    EventStatus status;
    float entryFee;
    int teamMax;

    #region PROPERTIES

  //  [DataMember]
    [JsonProperty("id")]
    public int Id { get => id; set => id = value; }
    
  //  [DataMember]
    [JsonProperty("name")]
    public string Name { get => name; set => name = value; } // Check for only alpahbet characters
    
  //  [DataMember]
    [JsonProperty("initial_date")]
    public DateTime StartDate { get => startDate; set => startDate = value; } // check if date > present

//    [DataMember]
    [JsonProperty("end_date")]
    public DateTime EndDate { get => endDate; set => endDate = value; } // check if endDate > startDate + date > present

 //   [DataMember]
    [JsonProperty("local")]
    public string Local { get => local; set => local = value; }

//    [DataMember]
    [JsonProperty("description")]
    public string Description { get => description; set => description = value; }

  //  [DataMember]
    [JsonProperty("slots")]
    public int Slots { get => slots; set => slots = value; } // only values > 0

//    [DataMember]
    [JsonProperty("status")]
    public EventStatus Status { get => status; set => status = value; }

//    [DataMember]
    [JsonProperty("entryfee")]
    public float EntryFee { get => entryFee; set => entryFee = value; }

   // [DataMember]
    [JsonProperty("teamMax")]
    public int TeamMax { get => teamMax; set => teamMax = value; } // only values > 0
    #endregion

    /* Data Structures */
    Dictionary<Team, DateTime> teams;
    List<Prize> prizeChart;

    public bool AddTeam(Team teamToAdd)
    {
        // check for space and if new team is null   +   lidar com slots
        return false;
    }

    public Event()
    {
        teams = new Dictionary<Team, DateTime>();
        prizeChart = new List<Prize>();
    }
}

