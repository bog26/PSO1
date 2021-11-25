using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class GenericDBUserQueries<T> : IQuery<T>
        where T : class, IPSOEntity
    {
        public List<T> ItemsList { get; set; }
        public GenericDBUserQueries(int Id)
        {
            var psContext = new psDBContext();
            var Items = psContext.GetDbSet<T>();
            //var queryItems = Items.Where(x => x.UserId == Id);
            //ItemsList = queryItems.ToList();
        }
        public List<T> GetItemsList()
        {
            return ItemsList;
        }
    }
}
