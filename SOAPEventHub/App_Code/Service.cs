﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{

	public void AssignClasses(Account account, Event eventA, Prize prize, Sport sport, Team team, User user, RootObject rootObject) { }

    public bool ValidateObject()
    {
        if (1 == 1) return true;
        /*
         * return false;
         * teams = new Dictionary<Team, DateTime>(); 
        prizeChart = new List<Prize>();
        */
    }

}
