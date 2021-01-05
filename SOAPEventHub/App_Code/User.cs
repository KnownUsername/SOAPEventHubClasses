using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//[DataContract]
public class User
{
    int id;
    string name;
    string email;
    string password;
    Account account;

    #region PROPERTIES
   // [DataMember]
    public int Id { get => id; set => id = value; }
    //[DataMember]
    public string Name { get => name; set => name = value; }
   // [DataMember]
    public string Email { get => email; set => email = value; }
    //[DataMember]
    public string Password { get => password; set => password = value; }
    #endregion


    public User()
    {
        account = new Account();
    }

    public User(string name, string email, string password)
    {
        account = new Account();
    }

    #region FUNCTIONS
    public bool CheckCredentials()
    {
        return true;
    }
    #endregion


}

