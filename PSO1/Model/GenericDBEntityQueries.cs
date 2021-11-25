using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PSO1.Model
{
    public class GenericDBEntityQueries<T> : IQuery<T>
        where T : class, IPSOEntity
    {
        public List<T> ItemsList { get; set; }
        private DbSet<T> Items { get; set; }
        private int Id { get; set; }
        public GenericDBEntityQueries(int id)
        {
            var psContext = new psDBContext();
            Items = psContext.GetDbSet<T>();
            Id = id;
        }
        public List<T> GetItemsList()
        {
            //var queryItems = Items.Where(x => x.ProductId == Id);
            //ItemsList = queryItems.ToList();
            return ItemsList;
        }
        public T GetItem()
        {
            var queryItem = Items.First(x => x.Id == Id);
            return queryItem;
        }
    }

}
