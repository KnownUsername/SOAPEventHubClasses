using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

//[DataContract]
public class Account
{
    string address;
    string shippingAddress;
    string bankId;

    #region PROPERTIES
  //  [DataMember]
    public string Address { get => address; set => address = value; }
    //[DataMember]
    public string ShippingAddress { get => shippingAddress; set => shippingAddress = value; }
    //[DataMember]
    public string BankId { get => bankId; set => bankId = value; }
    #endregion

    public Account()
    {

    }
}

