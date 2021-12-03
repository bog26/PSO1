using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    interface IAlarm
    {
        int Id { get; set; }
        int UserId { get; set; }
        //User User { get; set; }
        int ProductId { get; set; }
        //Product Product { get; set; }
        string message { get; set; }
        void CreateMessage();
    }
}
