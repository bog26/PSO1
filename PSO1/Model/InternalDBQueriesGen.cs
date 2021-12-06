﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class InternalDBQueriesGen<T>
    {
        public static bool CheckForExistingUserGen(string userName, IDbConnection<T> context)
        {
            bool exisitingUser = false;

            //var psContext = new psDBContext();
            //var psContext = new MSSQLConnection().Connection();
            //IDbConnection<psDBContext> psContext = (IDbConnection<psDBContext>)new MSSQLConnection().Connection();
            //IDbConnection

            var queryUsers = context.Users.Where(x => x.UserName == userName).ToList();
            if (queryUsers.Count != 0)
            {
                exisitingUser = true;
            }
            

            return exisitingUser;
        }

    }
}
