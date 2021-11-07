using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    interface IUser
    {
        int Id { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        bool isAdmin { get; set; }
        //UserPersonalData UserInfo { get; set; }
        string ToString();

    }
}
