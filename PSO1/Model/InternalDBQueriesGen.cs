using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class InternalDBQueriesGen<T> where T: IDbConnection<T>
    {
        //public static bool CheckForExistingUserGen(string userName, IDbConnection<T> context)
        public static bool CheckForExistingUserGen(string userName, T context)
        {
            bool exisitingUser = false;
            //var queryUsers = context.Users.Where(x => x.UserName == userName).ToList();
            var queryUsers = context.Users.Where(x => x.UserName == userName).ToList();
            if (queryUsers.Count != 0)
            {
                exisitingUser = true;
            }
            

            return exisitingUser;
        }

    }
}
