using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    //public class Admin : IUser
    public class Admin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserPersonalDataId { get; set; }
        public int UserAddressId { get; set; }

        //private UserPersonalData userInfo;
        //private UserAddress userAddress;

        public Admin()
        {

        }
        //public UserPersonalData UserInfo { get; set; }
        //public UserAddress UserAddress { get; set; }

        public void CreateAdmin(string chosenName, UserPersonalData personalInfo)
        {
            UserName = chosenName;
            //this.userInfo = personalInfo;
        }
        public override string ToString()
        {
            return UserName;
        }
    }
}
