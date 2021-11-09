using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class WishList
    {

        public int Id { get; set; }

        public string ClientName { get; set; }
        public string StringPIDs { get; set; } = string.Empty;

        public WishList()
        {

        }
        public WishList(string user)
        {
            ClientName = user;
        }
        public void AddPID(int PID)
        {
            string newPIDStr = PID.ToString();
            if (StringPIDs.Contains(newPIDStr))
            {
                return;
            }
            if (StringPIDs != string.Empty)
            {
                StringPIDs = StringPIDs + "," + newPIDStr;
            }
            else
            {
                StringPIDs = newPIDStr;
            }

        }

        public int[] getPIDs()
        {

            int[] PIDsIntArr = new int[] { };

            if (StringPIDs != string.Empty)
            {
                string[] PIDsStringArr = StringPIDs.Split(',');

                PIDsIntArr = new int[PIDsStringArr.Length];
                for (int i = 0; i < PIDsStringArr.Length; i++)
                {
                    PIDsIntArr[i] = int.Parse(PIDsStringArr[i]);

                }
            }

            return PIDsIntArr;
        }


    }
}
