using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public interface IQuery<T,U>
    {
        T AdminContext { get; set; }
        U ClientContext { get; set; }
        IQueryable UserDataQuery(T admin);

        IQueryable UserDataQuery(U client);
    }
}
