using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//[DataContract]
public class Prize
{
    int amount;
    Place position;

    #region PROPERTIES

  //  [DataMember]
    public int Value { get => amount; set => amount = value; }

    //[DataMember]
    public Place Position { get => position; set => position = value; }
    #endregion

    public Prize()
    {
        position = Place.na; // initialization of place as none, when created
    }
}
