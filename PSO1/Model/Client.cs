using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class Client : IUser
    {
        //[Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserPersonalDataId { get; set; }
        public int UserAddressId { get; set; }

        //public int WishListId { get; set; }
        public WishList WishList { get; set; }
        //public int WishListId { get; set; }
        //public int WishListId  { get; set; }
        //public List<int> WishList { get; set; }
        private UserPersonalData userInfo;
        private UserAddress userAddress;
        public Client()
        {
            //WishList = new List<int>();
            //WishList = new WishList(UserName);
        }
        public UserPersonalData UserInfo { get; set; }
        public UserAddress UserAddress { get; set; }
        public void CreateClient(string chosenName, UserPersonalData personalInfo)
        {
            UserName = chosenName;
            this.userInfo = personalInfo;
        }
        public override string ToString()
        {
            return UserName;
        }
        /*
        public void addPIDToWishList(int PID)
        {

            WishList.Add(PID);
        }*/
    }
}
