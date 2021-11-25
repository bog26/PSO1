using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    class ListQueries<T>
    {
        public List<T> ItemsList { get; set; } 
        /*
        public ListQueries<T>(int Id, List<T>)
        {
            var psContext = new psDBContext();
            var Items = psContext.GetDbSet<T>();
            var queryItems = Items.Where(x => x.ProductId == Id);
            ItemsList = queryItems.ToList();
        }*/

        /*
        public List<T> GetItemsList<T>(T entity) where T : class
        {
            var psContext = new psDBContext();
            var Items = psContext.GetDbSet<T>();
            var queryItems = Items.Where(x => x.ProductId == Id);
            var ItemsList = queryItems.ToList();
            return ItemsList;
        }*/

        /*
        public List<T> GetItemsList() 
        {
            return ItemsList;
        }
        public List<ISearchUserId> GetItemsList()
        {
            return ItemsList<ISearchUserId>;
        }
        */

        /*
        public List<T> GetItemsList<T>(T entity) where T : class
        {
            
            return null;
        }*/
    }
}
