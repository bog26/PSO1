using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PSO1.Model
{
    public class UserQuery  //TBD
    //public class UserQuery: IQuery<DbSet<Admin>, DbSet<Client>>
    //public class UserQuery : IQuery< Admin, Client>
    {
        
        /*
        public DbSet<Admin> AdminContext { get; set; }
        public DbSet<Client> ClientContext { get; set; }

        //public DbSet<Admin> UserDataQuery(DbSet<Admin> admin)
        public IQueryable UserDataQuery(Admin admin)
        {
            psDBContext psContext = new psDBContext();
            var query = from i in psContext.Admins
                        orderby i.Id
                        select new
                        {
                            i.Id,
                            UserName = i.UserName,
                            Name = i.UserInfo.FirstName,
                            LastName = i.UserInfo.LastName,
                            BirthDate = i.UserInfo.BirthDate,
                            email = i.UserInfo.Email,
                            Telephone = i.UserInfo.Telephone
                        };
            return query;
        }
        public IQueryable UserDataQuery(Client client)
        {
            psDBContext psContext = new psDBContext();
            var query = from i in psContext.Admins
                        orderby i.Id
                        select new
                        {
                            i.Id,
                            UserName = i.UserName,
                            Name = i.UserInfo.FirstName,
                            LastName = i.UserInfo.LastName,
                            BirthDate = i.UserInfo.BirthDate,
                            email = i.UserInfo.Email,
                            Telephone = i.UserInfo.Telephone
                        };
            return query;
        }
        */

    }
}
