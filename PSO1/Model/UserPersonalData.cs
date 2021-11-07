using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class UserPersonalData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string email;
        private string telephone;
        //public int AdminId;
        //public int ClientId;
        //private UserAddress address;

        public UserPersonalData()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
