using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class UserAddress
    {
        public int Id { get; set; }
        private string street;
        private int streetNr;
        private string city;
        private string region;
        private string country;
        private int postalCode;
        public int AdminId;
        public int ClientId;
        //public int UserPersonalDataId;
        public UserAddress()
        {

        }
        public string Street { get; set; }
        public int StreetNr { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }

    }
}
