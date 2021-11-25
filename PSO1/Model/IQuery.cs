using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public interface IQuery<T>
        where T : class
    {
        List<T> ItemsList { get; set; }
        List<T> GetItemsList();
    }
}
