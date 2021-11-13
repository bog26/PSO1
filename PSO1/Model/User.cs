using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class User:IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserPersonalDataId { get; set; }
        UserPersonalData UserPersonalData { get; set; }
        public int UserAddressId { get; set; }
        UserAddress UserAddress { get; set; }
        public bool isAdmin { get; set; }
        public decimal Credit { get; set; }
        public User()
        {
            isAdmin = false;
            Credit = 0;
        }
        public override string ToString()
        {
            return UserName;
        }
        public void ModifyCredit(decimal credit)
        {
            Credit += credit;
        }
        //public void Pay(decimal cost)
        //{
        //    Credit += cost;
        //}
    }
}
