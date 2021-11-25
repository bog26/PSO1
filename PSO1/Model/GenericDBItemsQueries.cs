using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

//https://entityframeworkcore.com/knowledge-base/33940507/find-a-generic-dbset-in-a-dbcontext-dynamically
//https://stackoverflow.com/questions/37697161/how-can-i-write-a-generic-query-with-ef-and-c-sharp
namespace PSO1.Model
{   
    public class GenericDBItemsQueries<T> : IQuery<T>
        where T : class, ISearchProductId
    {
        public List<T> ItemsList { get; set; }
        public GenericDBItemsQueries(int Id)
        {
            var psContext = new psDBContext();
            var Items = psContext.GetDbSet<T>();
            var queryItems = Items.Where(x => x.ProductId == Id);
            ItemsList = queryItems.ToList();
        }
        public List<T> GetItemsList()
        {
            return ItemsList;
        }
    } 
   
}
